using System.IO;

namespace mdbook_gui.Controls
{
    public static class MdbookEnv
    {
        public enum MdbookCommand
        {
            WEN_BOOK,
            CREATE_BOOK,
            ETAERC_BOOK,
            SERVE_BOOK
        }

        public static string ipAddres = "localhost";
        public static uint PortNumber = 3000;
        public static string WorkingDir = CONSTANTS.NULL_TEXT;

        public static void SetMdbookConsoleTask(ConsoleTask task, MdbookCommand cmd, string projectPath)
        {
            switch (cmd)
            {
                case MdbookCommand.WEN_BOOK:
                    task.SetCommandLine(CONSTANTS.MDBOOK_PATH, "init --force --theme" + " " + "\"" + projectPath + "\"", WorkingDir);
                    task.Command_info = "Creating Book...";
                    break;
                case MdbookCommand.CREATE_BOOK:
                    task.SetCommandLine(CONSTANTS.MDBOOK_PATH, "init --force" + " " + "\"" + projectPath + "\"", WorkingDir);
                    task.Command_info = "Creating Book...";
                    break;
                case MdbookCommand.ETAERC_BOOK:
                    task.SetCommandLine(CONSTANTS.MDBOOK_PATH, "build" + " " + "\"" + projectPath + "\"", WorkingDir);
                    task.Command_info = "Building Book...";
                    break;
                case MdbookCommand.SERVE_BOOK:
                    /*
                    task.SetCommandLine(CONSTANTS.MDBOOK_PATH, "serve -n" + " " + ipAddres + " " + "\"" + projectPath + "\"", WorkingDir);
                    */
                    task.SetCommandLine(CONSTANTS.MDBOOK_PATH, "serve" + " " + "\"" + projectPath + "\"", WorkingDir);
                    task.Command_info = "Starting Server...";
                    break;
                default:
                    break;
            }
        }

        public static bool CheckMdbookEnvironment()
        {
            // Check for existing environment
            return File.Exists(CONSTANTS.MDBOOK_PATH);
        }
    }

    internal static class CONSTANTS
    {
        public const string ROOT_FOLDER = @".";
        public const string ENV_FOLDER = ROOT_FOLDER + @"\mdbook-v0.4.9-x86_64-pc-windows-msvc";
        public const string MDBOOK_PATH = ENV_FOLDER + @"\mdbook.exe";
        /*
        
        */
        public const string NULL_TEXT = "";
        public const string BOOK_FOLDER = @"\book";
        public const string DEFAULT_ANSWER = "n";
        public const string NO_ANSWER = "y";
        public const string DOTNETCORE_EXPLORER = "explorer";
        public const string AUTHOR_URL = @"https://mingong.github.io";
    }
}
