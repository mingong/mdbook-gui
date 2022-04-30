using System;
using System.Windows;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Input;
using System.Runtime.CompilerServices;

using mdbook_gui.Controls;

namespace mdbook_gui
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// </summary>
        public MainWindowModel Model { get; set; } = new MainWindowModel();

        private IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponentMainForm()
        {
            components = new System.ComponentModel.Container();

            projectPanel = new Panel();
            toggleServerBtn = new Button();
            consoleTextBox = new RichTextBox();
            consoleMenuStrip = new ContextMenuStrip(components);
            copyConsoleToolStrip = new ToolStripMenuItem();
            copyAllConsoleToolStrip = new ToolStripMenuItem();
            clearConsoleToolStrip = new ToolStripMenuItem();
            projectPathLb = new Label();
            projectNameLb = new Label();
            portPanel = new Panel();
            portNumericBox = new NumericUpDown();
            label3 = new Label();
            serverStatusPanel = new Panel();
            hostLb = new Label();
            label1 = new Label();
            folderBrowserDialog = new FolderBrowserDialog();

            mainForm = new System.Windows.Forms.Integration.WindowsFormsHost();

            projectPanel.SuspendLayout();
            consoleMenuStrip.SuspendLayout();
            portPanel.SuspendLayout();
            ((ISupportInitialize)portNumericBox).BeginInit();
            serverStatusPanel.SuspendLayout();

            // 
            // projectPanel
            // 
            /*
            projectPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
            | AnchorStyles.Left
            | AnchorStyles.Right;
            */
            projectPanel.Controls.Add(toggleServerBtn);
            projectPanel.Controls.Add(consoleTextBox);
            projectPanel.Controls.Add(projectPathLb);
            projectPanel.Controls.Add(projectNameLb);
            projectPanel.Controls.Add(portPanel);
            projectPanel.Controls.Add(serverStatusPanel);
            projectPanel.Location = new System.Drawing.Point(0, 24);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new System.Drawing.Size(559, 418);
            projectPanel.TabIndex = 0;
            // 
            // toggleServerBtn
            // 
            toggleServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toggleServerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            toggleServerBtn.Location = new System.Drawing.Point(18, 70);
            toggleServerBtn.Name = "toggleServerBtn";
            toggleServerBtn.Size = new System.Drawing.Size(158, 48);
            toggleServerBtn.TabIndex = 1;
            toggleServerBtn.Text = "Start Server";
            toggleServerBtn.UseVisualStyleBackColor = true;
            toggleServerBtn.Click += new EventHandler(ToggleServerBtn_Click);
            // 
            // consoleTextBox
            // 
            consoleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
            | AnchorStyles.Left
            | AnchorStyles.Right;
            consoleTextBox.BackColor = System.Drawing.Color.Black;
            consoleTextBox.BorderStyle = BorderStyle.None;
            consoleTextBox.ContextMenuStrip = this.consoleMenuStrip;
            consoleTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            consoleTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            consoleTextBox.Location = new System.Drawing.Point(18, 124);
            consoleTextBox.MaxLength = 100000;
            consoleTextBox.Name = "consoleTextBox";
            consoleTextBox.ReadOnly = true;
            consoleTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            consoleTextBox.Size = new System.Drawing.Size(539, 278);
            consoleTextBox.TabIndex = 0;
            consoleTextBox.TabStop = false;
            consoleTextBox.Text = "Microsoft Windows [Version 10.0.10586]\n(c) 2015 Microsoft Corporation. All rights reserved.\n\nC:\\Users\\Mdbook>";
            // 
            // consoleMenuStrip
            // 
            consoleMenuStrip.Items.AddRange(new ToolStripItem[] {
            copyConsoleToolStrip,
            copyAllConsoleToolStrip,
            clearConsoleToolStrip});
            consoleMenuStrip.Name = "consoleMenuStrip";
            consoleMenuStrip.Size = new System.Drawing.Size(126, 80);
            consoleMenuStrip.Opening += new CancelEventHandler(ConsoleMenuStrip_Opening);
            // 
            // copyConsoleToolStrip
            // 
            copyConsoleToolStrip.Name = "copyConsoleToolStrip";
            copyConsoleToolStrip.Size = new System.Drawing.Size(119, 26);
            copyConsoleToolStrip.Text = "Copy";
            copyConsoleToolStrip.Click += new EventHandler(CopyConsoleToolStrip_Click);
            // 
            // copyAllConsoleToolStrip
            // 
            copyAllConsoleToolStrip.Name = "copyAllConsoleToolStrip";
            copyAllConsoleToolStrip.Size = new System.Drawing.Size(119, 26);
            copyAllConsoleToolStrip.Text = "Copy All";
            copyAllConsoleToolStrip.Click += new EventHandler(CopyAllConsoleToolStrip_Click);
            // 
            // clearConsoleToolStrip
            // 
            clearConsoleToolStrip.Name = "clearConsoleToolStrip";
            clearConsoleToolStrip.Size = new System.Drawing.Size(119, 26);
            clearConsoleToolStrip.Text = "Clear";
            clearConsoleToolStrip.Click += new EventHandler(ClearConsoleToolStrip_Click);
            // 
            // projectPathLb
            // 
            projectPathLb.Anchor = AnchorStyles.Top | AnchorStyles.Left
            | AnchorStyles.Right;
            projectPathLb.AutoEllipsis = true;
            projectPathLb.Cursor = System.Windows.Forms.Cursors.Hand;
            projectPathLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            projectPathLb.Location = new System.Drawing.Point(18, 40);
            projectPathLb.Name = "projectPathLb";
            projectPathLb.Size = new System.Drawing.Size(539, 26);
            projectPathLb.TabIndex = 0;
            projectPathLb.Text = "C:\\Mdbook\\Data\\GitHub\\example.github.io";
            projectPathLb.Click += new EventHandler(ProjectPathLb_Click);
            // 
            // projectNameLb
            // 
            projectNameLb.AutoSize = true;
            projectNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            projectNameLb.Location = new System.Drawing.Point(18, 17);
            projectNameLb.Name = "projectNameLb";
            projectNameLb.Size = new System.Drawing.Size(104, 26);
            projectNameLb.TabIndex = 0;
            projectNameLb.Text = "Project Name";
            // 
            // portPanel
            // 
            portPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left
            | AnchorStyles.Right;
            portPanel.Controls.Add(portNumericBox);
            portPanel.Controls.Add(label3);
            portPanel.Location = new System.Drawing.Point(176, 70);
            portPanel.Name = "portPanel";
            portPanel.Size = new System.Drawing.Size(289, 48);
            portPanel.TabIndex = 0;
            // 
            // portNumericBox
            // 
            portNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            portNumericBox.Location = new System.Drawing.Point(47, 17);
            portNumericBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            portNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            portNumericBox.Name = "portNumericBox";
            portNumericBox.Size = new System.Drawing.Size(86, 23);
            portNumericBox.TabIndex = 2;
            portNumericBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            portNumericBox.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            portNumericBox.ValueChanged += new EventHandler(PortNumericBox_ValueChanged);
            portNumericBox.KeyUp += new System.Windows.Forms.KeyEventHandler(PortNumericBox_KeyUp);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(3, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 17);
            label3.TabIndex = 0;
            label3.Text = "Port:";
            // 
            // serverStatusPanel
            // 
            serverStatusPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left
            | AnchorStyles.Right;
            serverStatusPanel.Controls.Add(hostLb);
            serverStatusPanel.Controls.Add(label1);
            serverStatusPanel.Location = new System.Drawing.Point(168, 70);
            serverStatusPanel.Name = "serverStatusPanel";
            serverStatusPanel.Size = new System.Drawing.Size(289, 48);
            serverStatusPanel.TabIndex = 0;
            // 
            // hostLb
            // 
            hostLb.Anchor = AnchorStyles.Top | AnchorStyles.Left
            | AnchorStyles.Right;
            hostLb.AutoEllipsis = true;
            hostLb.Cursor = System.Windows.Forms.Cursors.Hand;
            hostLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            hostLb.ForeColor = System.Drawing.Color.RoyalBlue;
            hostLb.Location = new System.Drawing.Point(94, 17);
            hostLb.Name = "hostLb";
            hostLb.Size = new System.Drawing.Size(213, 26);
            hostLb.TabIndex = 0;
            hostLb.Text = "http://localhost:3000";
            hostLb.Click += new EventHandler(HostLb_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(8, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 17);
            label1.TabIndex = 0;
            label1.Text = "Hostname:";
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.Description = "Choose location";
            // 
            // MainForm
            // 

            mainForm.Child = projectPanel;

            _ = grid.Children.Add(mainForm);

            Name = "MainForm";

            projectPanel.ResumeLayout(false);
            projectPanel.PerformLayout();
            consoleMenuStrip.ResumeLayout(false);
            portPanel.ResumeLayout(false);
            portPanel.PerformLayout();
            ((ISupportInitialize)portNumericBox).EndInit();
            serverStatusPanel.ResumeLayout(false);
            serverStatusPanel.PerformLayout();

        }

        #endregion

        private Panel projectPanel;
        private Label projectNameLb;
        private Label projectPathLb;
        private RichTextBox consoleTextBox;
        private Label hostLb;
        private Label label1;
        private Button toggleServerBtn;
        private FolderBrowserDialog folderBrowserDialog;
        private Panel serverStatusPanel;
        private ContextMenuStrip consoleMenuStrip;
        private ToolStripMenuItem copyAllConsoleToolStrip;
        private ToolStripMenuItem clearConsoleToolStrip;
        private ToolStripMenuItem copyConsoleToolStrip;
        private Panel portPanel;
        private Label label3;
        private NumericUpDown portNumericBox;
        private System.Windows.Forms.Integration.WindowsFormsHost mainForm;
        private string projectPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Path.GetFileNameWithoutExtension(System.Windows.Forms.Application.ExecutablePath));
        /*
        private string projectName = CONSTANTS.NULL_TEXT;
        */
        private string projectName = Path.GetFileNameWithoutExtension(System.Windows.Forms.Application.ExecutablePath);
        private readonly ConsoleTask serveTask = new ConsoleTask();
        private readonly ConsoleTask newTask = new ConsoleTask();
        private readonly ConsoleTask buildTask = new ConsoleTask();

        public MainWindow()
        {
            InitializeComponent();

            InitializeComponentMainForm();

            Loaded += MainWindow_Loaded;

            ConsoleTask.SetForm(this);
            ConsoleTask.SetConsole(consoleTextBox);

            serveTask.AddTaskCompleteEventHandler(Serve_TaskComplete);

            UpdateMdbookTasks();

            _ = CommandBindings.Add(new CommandBinding(ApplicationCommands.New, FromTemplateToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, OpenToolStrip_Click));

            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.DefaultProject, DefaultProjectToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Export, ExportToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Close, CloseToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Exit, ExitToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.ToggleServer, ToggleServerToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Build, BuildToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Rebuild, RebuildToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Clean, CleanToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Mdbook, MdbookToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Commonmark, CommonmarkToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.Webdev, WebdevToolStrip_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.MingongSeparator, MingongSeparator_Click));
            _ = CommandBindings.Add(new CommandBinding(Mdbook_GuiCommands.About, AboutToolStrip_Click));
        }

        private void UpdateMdbookTasks()
        {
            MdbookEnv.ipAddres = Tools.GetLocalAddress();
            MdbookEnv.PortNumber = (uint)portNumericBox.Value;
            /*
            MdbookEnv.WorkingDir = projectPath;
            */
            MdbookEnv.SetMdbookConsoleTask(serveTask, MdbookEnv.MdbookCommand.SERVE_BOOK, projectPath);
            MdbookEnv.SetMdbookConsoleTask(newTask, MdbookEnv.MdbookCommand.CREATE_BOOK, projectPath);
            MdbookEnv.SetMdbookConsoleTask(buildTask, MdbookEnv.MdbookCommand.ETAERC_BOOK, projectPath);
        }

        private void StartServer()
        {
            if (newTask.Running)
            {
                return;
            }

            MdbookEnv.SetMdbookConsoleTask(serveTask, MdbookEnv.MdbookCommand.SERVE_BOOK, projectPath);

            serveTask.RunTaskAsync();

            /*
            hostLb.Text = "http:\\\\" + Tools.GetLocalAddress() + ":" + portNumericBox.Value;
            */
            hostLb.Text = "http:\\\\localhost:3000";
            toggleServerBtn.Text = "Stop Server";
            toggleServerBtn.ForeColor = System.Drawing.Color.DarkRed;
            toggleServerBtn.Enabled = true;
            portPanel.Visible = portPanel.Enabled = false;
            serverStatusPanel.Enabled = serverStatusPanel.Visible = true;
            cleanToolStrip.IsEnabled = buildToolStrip.IsEnabled = exportToolStrip.IsEnabled = rebuildToolStrip.IsEnabled = false;

            System.Windows.Controls.ToolTip tt = new System.Windows.Controls.ToolTip
            {
                Content = "Stop server first"
            };

            cleanToolStrip.ToolTip = buildToolStrip.ToolTip = exportToolStrip.ToolTip = rebuildToolStrip.ToolTip = tt;

            return;
        }

        private void StopServer()
        {
            toggleServerBtn.Enabled = false;
            serveTask.StopTask();

            toggleServerBtn.Text = "Start Server";
            toggleServerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            toggleServerBtn.Enabled = true;
            serverStatusPanel.Enabled = serverStatusPanel.Visible = false;
            portPanel.Visible = portPanel.Enabled = true;
            cleanToolStrip.IsEnabled = buildToolStrip.IsEnabled = exportToolStrip.IsEnabled = rebuildToolStrip.IsEnabled = true;

            System.Windows.Controls.ToolTip tt = new System.Windows.Controls.ToolTip
            {
                /*
                Content = null
                */
                Content = projectName
            };

            cleanToolStrip.ToolTip = buildToolStrip.ToolTip = exportToolStrip.ToolTip = rebuildToolStrip.ToolTip = tt;

            if (!projectPanel.Visible)
            {
                exportToolStrip.IsEnabled = false;
            }
        }

        private void ToggleServer()
        {
            if (serveTask.Running)
            {
                StopServer();
            }
            else
            {
                StartServer();
            }
        }

        private bool BrowseFolder(out string path, bool empty)
        {
            path = null;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;

                try
                {
                    if (empty && Directory.GetFileSystemEntries(path).Length != 0)
                    {
                        DialogResult result = System.Windows.Forms.MessageBox.Show("Selected folder is not empty. Proceed anyways?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        if (result == System.Windows.Forms.DialogResult.Cancel)
                        {
                            return false;
                        }

                        if (result == System.Windows.Forms.DialogResult.No)
                        {
                            return BrowseFolder(out path, empty);
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Tools.DisplayError("Could not browse folder.", ex);

                    return false;
                }
            }

            return false;
        }

        private void CreateWenProject()
        {
            MdbookEnv.SetMdbookConsoleTask(newTask, MdbookEnv.MdbookCommand.WEN_BOOK, projectPath);
            newTask.RunTaskSync(new NewMessage() { Nory = CONSTANTS.NO_ANSWER, BookTitle = projectName });

            if (NotAsciiChars(projectName))
            {
                AppendBookTitle();
            }
        }

        /// <summary>
        /// Create a new demo project (runs mdbook init)
        /// </summary>
        private void CreateNewProject()
        {
            if (!OpenProject(true))
            {
                return;
            }

            newTask.RunTaskSync(new NewMessage() { Nory = CONSTANTS.NO_ANSWER, BookTitle = projectName });

            if (NotAsciiChars(projectName))
            {
                AppendBookTitle();
            }

            return;
        }

        private bool NotAsciiChars(string str)
        {
            return System.Text.Encoding.UTF8.GetByteCount(str) != str.Length;
        }

        private void AppendBookTitle()
        {
            /*
            if (newTask.Running)
            {
                return;
            }

            */
            string fullPath;

            fullPath = Path.Combine(projectPath, "book.toml");

            TextWriter wr = new StreamWriter(fullPath, true);
            wr.WriteLine("title" + " = " + "\"" + projectName + "\"");
            wr.Close();
            /*

            return;
            */
        }

        private bool OpenProject(bool empty) { return OpenProject(null, empty); }

        private bool OpenProject(string path, bool empty)
        {
            if (string.IsNullOrEmpty(path) && !BrowseFolder(out path, empty))
            {
                return false;
            }

            CloseProject();

            projectName = projectNameLb.Text = path[(path.LastIndexOfAny(new char[] { '\\', '/' }) + 1)..];
            projectPathLb.Text = projectPath = path;
            projectPanel.Visible = projectPanel.Enabled = projectMenu.IsEnabled = exportToolStrip.IsEnabled = true;

            cleanToolStrip.IsEnabled = buildToolStrip.IsEnabled = toggleServerToolStrip.IsEnabled = rebuildToolStrip.IsEnabled = true;

            System.Windows.Controls.ToolTip tt = new System.Windows.Controls.ToolTip
            {
                Content = projectName
            };
            cleanToolStrip.ToolTip = buildToolStrip.ToolTip = exportToolStrip.ToolTip = rebuildToolStrip.ToolTip = tt;

            UpdateMdbookTasks();

            _ = portNumericBox.Focus();

            return true;
        }

        private void ExportProject()
        {
            string buildDir = projectPath + CONSTANTS.BOOK_FOLDER;

            // Build site if needed
            if (!Directory.Exists(buildDir))
            {
                buildTask.RunTaskSync(null);
            }

            // Browse for export dir
            if (!BrowseFolder(out string outDir, true))
            {
                return;
            }

            consoleTextBox.Clear();
            consoleTextBox.AppendText("Copying files..." + Environment.NewLine);

            if (Tools.DirectoryCopy(buildDir, outDir))
            {
                consoleTextBox.AppendText("Successfully exported Book to" + " " + outDir + Environment.NewLine);
            }
            else
            {
                consoleTextBox.AppendText("Aborted." + Environment.NewLine);
            }

            return;
        }

        private void CleanProject()
        {
            string[] paths = { CONSTANTS.BOOK_FOLDER };
            foreach (string path in paths)
            {
                if (!Tools.DirectoryDelete(projectPath + path))
                {
                    return;
                }
            }

            consoleTextBox.Clear();

            return;
        }

        private void CloseProject()
        {
            StopServer();

            projectPanel.Visible = projectPanel.Enabled = projectMenu.IsEnabled = exportToolStrip.IsEnabled = false;

            cleanToolStrip.IsEnabled = buildToolStrip.IsEnabled = toggleServerToolStrip.IsEnabled = rebuildToolStrip.IsEnabled = false;

            consoleTextBox.Text = CONSTANTS.NULL_TEXT;

            projectNameLb.Text = projectPathLb.Text = CONSTANTS.NULL_TEXT;
            projectName = Path.GetFileNameWithoutExtension(System.Windows.Forms.Application.ExecutablePath);
            projectPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Path.GetFileNameWithoutExtension(System.Windows.Forms.Application.ExecutablePath));
        }

        #region Event Handlers
        private void MainWindow_Loaded(object sender, EventArgs e)
        {
            // Check for environment
            if (!MdbookEnv.CheckMdbookEnvironment())
            {
                Close();
            }

            CloseProject();

            // Restore state
            string path = Settings.Default.LastOpenPath_;
            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                _ = OpenProject(path, false);
            }
        }

        private void FromTemplateToolStrip_Click(object sender, EventArgs e)
        {
            if (!OpenProject(true))
            {
                return;
            }

            CreateWenProject();

            return;
        }

        private void DefaultProjectToolStrip_Click(object sender, EventArgs e)
        {
            CreateNewProject();
        }

        private void OpenToolStrip_Click(object sender, EventArgs e)
        {
            _ = OpenProject(false);
        }

        private void ExportToolStrip_Click(object sender, EventArgs e)
        {
            ExportProject();
        }

        private void CloseToolStrip_Click(object sender, EventArgs e)
        {
            CloseProject();
        }

        private void ExitToolStrip_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToggleServerToolStrip_Click(object sender, EventArgs e)
        {
            toggleServerBtn.PerformClick();
        }

        private void BuildToolStrip_Click(object sender, EventArgs e)
        {
            buildTask.RunTaskSync(null);
        }

        private void RebuildToolStrip_Click(object sender, EventArgs e)
        {
            // Rebuild is clean + build
            CleanToolStrip_Click(sender, e);
            BuildToolStrip_Click(sender, e);
        }

        private void CleanToolStrip_Click(object sender, EventArgs e)
        {
            CleanProject();
        }

        private void MdbookToolStrip_Click(object sender, EventArgs e)
        {
            _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, @"https://rust-lang.github.io/mdBook/");
        }

        private void CommonmarkToolStrip_Click(object sender, EventArgs e)
        {
            _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, @"https://commonmark.org/");
        }

        private void WebdevToolStrip_Click(object sender, EventArgs e)
        {
            _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, @"https://web.dev/");
        }

        private void MingongSeparator_Click(object sender, EventArgs e)
        {
            // Easter Egg
            _ = System.Windows.Forms.MessageBox.Show("This product was possible thanks to the power of Wuang. For more info and awesomeness, a website will appear.", "Wuang Power", MessageBoxButtons.OK);

            _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, CONSTANTS.AUTHOR_URL);
        }

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {
            Form f = new Forms.AboutForm();
            _ = f.ShowDialog();
        }

        private void ConsoleMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            copyConsoleToolStrip.Visible = consoleTextBox.SelectionLength != 0;
            e.Cancel = consoleTextBox.TextLength == 0;
        }

        private void CopyConsoleToolStrip_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(consoleTextBox.SelectedText);
        }

        private void CopyAllConsoleToolStrip_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(consoleTextBox.Text);
        }

        private void ClearConsoleToolStrip_Click(object sender, EventArgs e)
        {
            consoleTextBox.Clear();
        }

        private void ProjectPathLb_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(projectPath))
            {
                _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, projectPath);
            }
            else
            {
                Tools.DisplayError("Path not found. Please make sure the project exists.");
            }
        }

        private void HostLb_Click(object sender, EventArgs e)
        {
            _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, hostLb.Text);
        }

        private void ToggleServerBtn_Click(object sender, EventArgs e)
        {
            ToggleServer();
        }

        private void PortNumericBox_ValueChanged(object sender, EventArgs e)
        {
            // Update port
            MdbookEnv.PortNumber = (uint)portNumericBox.Value;
        }

        private void PortNumericBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartServer();
            }
        }

        private void Serve_TaskComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            StopServer();
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            // Save state

            Settings.Default.LastOpenPath_ = projectPath;
            Settings.Default.Save();
        }
        #endregion

    }

    public class NewMessage
    {
        public string Nory { get; set; } = CONSTANTS.DEFAULT_ANSWER;
        public string BookTitle { get; set; } = CONSTANTS.NULL_TEXT;
    }

    public class MainWindowModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
