using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    public partial class FolderForm : Form
    {
        private string latestFolder;

        public FolderForm()
        {
            InitializeComponent();
        }

        public IEnumerable<string> SelectedFiles
        {
            get
            {
                List<string> selectedFiles = new List<string>(listViewFiles.Items.Count);

                foreach (ListViewItem item in listViewFiles.Items)
                {
                    if (item.Checked)
                        selectedFiles.Add((string)item.Tag);
                }

                return selectedFiles;
            }
        }

        public string SelectedFolder { get; private set; }

        private void OnFolderFormLoad(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;

            if (settings.RememberLastSelectedFolder)
                latestFolder = settings.LastSelectedFolder ?? string.Empty;
        }

        private void OnButtonFolderClick(object sender, EventArgs e)
        {
            if (latestFolder != null)
                folderBrowserDialog.SelectedPath = latestFolder;

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                ClearSelectedFolder();
                return;
            }

            SelectedFolder = folderBrowserDialog.SelectedPath;
            textFolder.Text = SelectedFolder;
            latestFolder = SelectedFolder;

            if (Directory.Exists(SelectedFolder))
            {
                Properties.Settings settings = Properties.Settings.Default;

                if (settings.RememberLastSelectedFolder)
                {
                    settings.LastSelectedFolder = latestFolder;
                    settings.Save();
                }

                ShowSelectedFiles(SelectedFolder);
            }
            else
            {
                ClearSelectedFolder();
            }
        }

        private void ClearSelectedFolder()
        {
            SelectedFolder = string.Empty;
            textFolder.Text = SelectedFolder;
            listViewFiles.Items.Clear();
        }

        private void OnCheckSelectAllFilesCheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewFiles.Items)
                item.Checked = checkSelectAllFiles.Checked;
        }

        private void OnButtonAcceptClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ShowSelectedFiles(string selectedFolder)
        {
            listViewFiles.Items.Clear();

            string[] exclude = new string[0];

            // Check if user has given extension to exclude from rename like "txt" or ".txt".
            if (!string.IsNullOrWhiteSpace(textExclude.Text))
            {
                // Expect multiple extension to be separated by comma.
                // Ensure that extensions start with "."
                if (textExclude.Text.IndexOf(',') >= 0)
                    exclude = textExclude.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(value => value.StartsWith(".") ? value : "." + value).ToArray();
                else
                    exclude = new string[] { textExclude.Text.StartsWith(".") ? textExclude.Text :  "." + textExclude.Text };
            }

            // Enumerate file in selected folder.
            string[] files = Directory.EnumerateFiles(selectedFolder).ToArray();

            // Then get selected files.
            files = FileSelectionHelper.GetSelectedFiles(files);

            foreach (string file in files)
            {
                // Check if file should be excluded based on value given in this form.
                if (exclude.Length > 0 && exclude.Any(ex => string.Equals(ex, Path.GetExtension(file), StringComparison.OrdinalIgnoreCase)))
                    continue;

                // Check if show full path or only file name.
                string value = Program.ShowFullFilePaths ? file : Path.GetFileName(file);

                // Create list view item based on file.
                ListViewItem item = new ListViewItem(new[] { value });
                item.Tag = file;
                item.Checked = checkSelectAllFiles.Checked;
                listViewFiles.Items.Add(item);
            }
        }

        private void OnListViewFilesDrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            ListViewHelper.DrawCustomHeader(listViewFiles, e);
        }

        private void OnListViewFilesDrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void OnListViewFilesDrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void OnButtonRefreshClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SelectedFolder))
                return;

            ShowSelectedFiles(SelectedFolder);
        }
    }
}
