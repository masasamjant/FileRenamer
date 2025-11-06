using System;
using System.IO;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private bool ShowSingleFileNameColumn { get; set; }

        private bool ShowFullFilePaths { get; set; }

        private void OnOptionsFormLoad(object sender, EventArgs e)
        {
            // Remove handlers to not handle event when set from settings.
            checkShowSingleFileNameColumn.CheckedChanged -= OnCheckShowSingleFileNameColumnCheckedChanged;
            checkShowFullFilePaths.CheckedChanged -= OnCheckShowFullFilePathsCheckedChanged;

            Properties.Settings settings = Properties.Settings.Default;
            numericMaxFiles.Value = settings.MaxCountOfRenamedFiles;

            if (!string.IsNullOrWhiteSpace(settings.ExcludeFileExtension))
                textExcluceExtensions.Text = settings.ExcludeFileExtension;

            if (!string.IsNullOrWhiteSpace(settings.LogLocation))
                textLogFolder.Text = settings.LogLocation;

            checkRememberLastSelectedFolder.Checked = settings.RememberLastSelectedFolder;
            checkShowSingleFileNameColumn.Checked = settings.ShowSingleFileNameColumn;
            checkShowFullFilePaths.Checked = settings.ShowFullFilePaths;
            ShowSingleFileNameColumn = settings.ShowSingleFileNameColumn;
            ShowFullFilePaths = settings.ShowFullFilePaths;

            // Set handles back to see if user change value.
            checkShowSingleFileNameColumn.CheckedChanged += OnCheckShowSingleFileNameColumnCheckedChanged;
            checkShowFullFilePaths.CheckedChanged += OnCheckShowFullFilePathsCheckedChanged;
        }

        private void OnButtonOkClick(object sender, EventArgs e)
        {
            FileRenameLogProvider.Current.Log.Write("Save setting changes.");
            FileRenameLogProvider.Current.Log.Write("Close Options form.");
            Properties.Settings settings = Properties.Settings.Default;
            settings.MaxCountOfRenamedFiles = Convert.ToInt32(numericMaxFiles.Value);
            settings.ExcludeFileExtension = ValidateExcludeFileExtensions(textExcluceExtensions.Text);
            settings.LogLocation = textLogFolder.Text;
            settings.RememberLastSelectedFolder = checkRememberLastSelectedFolder.Checked;
            settings.ShowSingleFileNameColumn = checkShowSingleFileNameColumn.Checked;
            settings.ShowFullFilePaths = checkShowFullFilePaths.Checked;
            settings.Save();
            Close();
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            FileRenameLogProvider.Current.Log.Write("Cancel setting changes.");
            FileRenameLogProvider.Current.Log.Write("Close Options form.");
            Close();
        }

        private void OnButtonBrowseLogLocationClick(object sender, EventArgs e)
        {
            string logLocation = textLogFolder.Text;

            if (string.IsNullOrWhiteSpace(logLocation))
            {
                string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string currentDirectory = Path.Combine(myDocumentsPath, "MasaSamFileRenameManager");
                string defaultLogDirectory = Path.Combine(currentDirectory, "Logs");

                if (!Directory.Exists(defaultLogDirectory))
                    Directory.CreateDirectory(defaultLogDirectory);

                logLocation = defaultLogDirectory;
            }

            logFolderDialog.SelectedPath = logLocation;

            if (logFolderDialog.ShowDialog() == DialogResult.OK)
            {
                textLogFolder.Text = logFolderDialog.SelectedPath;
            }
        }

        private string ValidateExcludeFileExtensions(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            return value;
        }

        private void OnCheckShowSingleFileNameColumnCheckedChanged(object sender, EventArgs e)
        {
            panelRestartMessage.Visible = checkShowSingleFileNameColumn.Checked != ShowSingleFileNameColumn;
        }

        private void OnCheckShowFullFilePathsCheckedChanged(object sender, EventArgs e)
        {
            panelRestartMessage.Visible = checkShowFullFilePaths.Checked != ShowFullFilePaths;
        }
    }
}
