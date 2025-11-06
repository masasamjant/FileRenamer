using System;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    static class Program
    {
        public static bool ShowSingleFileNameColumn { get; private set; }

        public static bool ShowFullFilePaths { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Properties.Settings settings = Properties.Settings.Default;
            ShowSingleFileNameColumn = settings.ShowSingleFileNameColumn;
            ShowFullFilePaths = settings.ShowFullFilePaths;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
