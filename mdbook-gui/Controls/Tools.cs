using System;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace mdbook_gui.Controls
{
    internal static class Tools
    {
        // DisplayError
        public static void DisplayError(string info) { DisplayError(info, null); }

        public static void DisplayError(string info, Exception e)
        {
            _ = e != null
                ? MessageBox.Show(info + Environment.NewLine + "Error message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                : MessageBox.Show(info, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string GetLocalAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "localhost";
        }

        public static bool DirectoryCopy(string sourcePath, string destPath)
        {
            if (!Directory.Exists(sourcePath))
            {
                return false;
            }

            try
            {
                _ = Directory.CreateDirectory(destPath);

                foreach (string fileA in Directory.GetFiles(sourcePath))
                {
                    string fileB = fileA.Replace(sourcePath, destPath);

                    if (File.Exists(fileB))
                    {
                        File.Delete(fileB);
                    }

                    File.Copy(fileA, fileB);
                }

                foreach (string dirA in Directory.GetDirectories(sourcePath))
                {
                    string dirB = dirA.Replace(sourcePath, destPath);

                    if (!DirectoryCopy(dirA, dirB))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception e) { DisplayError("io error occured while copying directory.", e); return false; }
        }

        public static bool DirectoryMove(string sourcePath, string destPath)
        {
            if (!Directory.Exists(sourcePath))
            {
                return false;
            }

            try
            {
                if (!Directory.Exists(destPath))
                {
                    Directory.Move(sourcePath, destPath);

                    return true;
                }

                foreach (string fileA in Directory.GetFiles(sourcePath))
                {
                    string fileB = fileA.Replace(sourcePath, destPath);

                    if (File.Exists(fileB))
                    {
                        File.Delete(fileB);
                    }

                    File.Move(fileA, fileB);
                }

                foreach (string dirA in Directory.GetDirectories(sourcePath))
                {
                    string dirB = dirA.Replace(sourcePath, destPath);

                    if (!DirectoryMove(dirA, dirB))
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception e) { DisplayError("io error occured while moving directory.", e); return false; }
        }

        public static bool DirectoryDelete(string dirPath)
        {
            try
            {
                if (Directory.Exists(dirPath))
                {
                    Directory.Delete(dirPath, true);
                }

                return true;
            }
            catch (Exception ex)
            {
                DisplayError("Could not delete \"" + dirPath + "\".", ex);

                return false;
            }
        }
    }
}
//  mdbook-gui\Controls\Tools.cs