using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System;
using System.Drawing;
using System.Windows;

namespace mdbook_gui.Controls
{
    public class ConsoleTask
    {
        private static Window window = null;
        private static RichTextBox console = null;
        private static bool closePending = false;
        private static readonly AutoResetEvent allClosed = new AutoResetEvent(false);
        private static int runningTasks = 0;
        private static readonly Mutex mux = new Mutex();

        public string Command_info;
        private readonly Process proc = new Process();
        private readonly BackgroundWorker bw = new BackgroundWorker();
        private readonly AutoResetEvent isDone = new AutoResetEvent(false);

        private NewMessage wenMessage = null;

        public ConsoleTask() : this(null, null, null, null) { }

        public ConsoleTask(string command, string args, string workingDir, string command_info)
        {
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;

            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardError = true;

            proc.OutputDataReceived += Proc_OutputDataReceived;
            proc.ErrorDataReceived += Proc_OutputDataReceived;

            SetCommandLine(command, args, workingDir);
            Command_info = command_info;

            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            proc.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;
            proc.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
        }


        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            _ = mux.WaitOne();
            runningTasks++;
            _ = allClosed.Reset();
            mux.ReleaseMutex();

            _ = isDone.Reset();

            try
            {
                _ = proc.Start();

                if (wenMessage != null)
                {
                    proc.StandardInput.WriteLine(CONSTANTS.DEFAULT_ANSWER);

                    if (AsciiChars(wenMessage.BookTitle))
                    {
                        proc.StandardInput.WriteLine(wenMessage.BookTitle);
                    }
                    else
                    {
                        proc.StandardInput.WriteLine();
                    }

                    wenMessage = null;
                }

                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();

                while (!proc.HasExited && !bw.CancellationPending && !closePending)
                {
                    Thread.Sleep(100);
                }

                if (!proc.HasExited)
                {
                    proc.Kill();
                }

                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                }

                proc.CancelOutputRead();
                proc.CancelErrorRead();
            }
            catch (Exception exception)
            {
                Tools.DisplayError("Could not start process. Make sure the project exists and then retry.", exception);
                e.Cancel = true;
            }

            _ = isDone.Set();

            _ = mux.WaitOne();
            runningTasks--;
            if (runningTasks == 0)
            {
                _ = allClosed.Set();
            }

            mux.ReleaseMutex();
        }

        /*
        */
        private bool AsciiChars(string str)
        {
            return System.Text.Encoding.UTF8.GetByteCount(str) == str.Length;
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                WriteToConsole((string)e.UserState);
            }
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            bw.ReportProgress(0, e.Data);
        }

        public void SetCommandLine(string command, string args, string workingDir)
        {
            proc.StartInfo.FileName = command;
            proc.StartInfo.Arguments = args;
            proc.StartInfo.WorkingDirectory = workingDir;
        }

        public void RunTaskAsync()
        {
            if (!bw.IsBusy)
            {
                ClearConsole();
                WriteToConsole(Command_info);
                bw.RunWorkerAsync();
            }
        }

        public void RunTaskSync(NewMessage newMessage)
        {
            if (!bw.IsBusy)
            {
                wenMessage = newMessage;

                RunTaskAsync();

                if (console != null)
                {
                    console.Invalidate();
                    console.Update();
                }

                _ = isDone.WaitOne();
                SetConsoleColor();
            }
        }

        public void StopTask()
        {
            if (bw.IsBusy)
            {
                bw.CancelAsync();
                _ = isDone.WaitOne();
                SetConsoleColor();
            }
        }

        public bool Running
        {
            get { return bw.IsBusy; }
        }

        public void AddTaskCompleteEventHandler(RunWorkerCompletedEventHandler h)
        {
            bw.RunWorkerCompleted += h;
        }

        public static void SetConsole(RichTextBox console)
        {
            if (console != null)
            {
                ConsoleTask.console = console;
                ConsoleTask.console.Clear();
                SetConsoleColor();
            }
        }

        public static void SetForm(Window window)
        {
            if (window != null)
            {
                ConsoleTask.window = window;
                ConsoleTask.window.Closing += Window_Closing;
            }
        }

        private static void SetConsoleColor() { SetConsoleColor(Color.Empty); }

        private static void SetConsoleColor(Color c)
        {
            if (console != null && !console.IsDisposed)
            {
                console.SelectionStart = console.TextLength;
                console.SelectionLength = 0;
                console.SelectionColor = c == Color.Empty ? console.ForeColor : c;
            }
        }

        private static void WriteToConsole(string line)
        {
            if (console != null && !console.IsDisposed && line != null)
            {
                int a;
                while ((a = line.IndexOf("\x1b[")) >= 0)
                {
                    console.AppendText(line.Substring(0, a));
                    line = line.Remove(0, a + 2);
                    if (line.Length < 2)
                    {
                        return;
                    }

                    if (line[0] == '0' && line[1] == 'm')
                    {
                        SetConsoleColor();
                        line = line.Remove(0, 2);
                    }
                    else
                    {
                        if (line.Length < 3)
                        {
                            return;
                        }

                        if (line.Substring(0, 3) == "31m")
                        {
                            SetConsoleColor(Color.Red);
                            line = line.Remove(0, 3);
                        }
                        else if (line.Substring(0, 3) == "33m")
                        {
                            SetConsoleColor(Color.Yellow);
                            line = line.Remove(0, 3);
                        }
                        else if (line[2] == 'm')
                        {
                            line = line.Remove(0, 3);
                        }
                    }
                }
                console.AppendText(line);
                console.AppendText(Environment.NewLine);
            }
            return;
        }

        private static void ClearConsole()
        {
            if (console != null && !console.IsDisposed)
            {
                console.Clear();
                SetConsoleColor(console.ForeColor);
            }
        }

        private static void Window_Closing(object sender, CancelEventArgs e)
        {
            int a;
            _ = mux.WaitOne();
            a = runningTasks;
            mux.ReleaseMutex();

            if (a > 0)
            {
                closePending = true;
                _ = allClosed.WaitOne();
            }
        }
    }
}
