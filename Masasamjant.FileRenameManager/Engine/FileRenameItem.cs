using System.IO;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    /// <summary>
    /// Class presenting renamed file.
    /// </summary>
    public class FileRenameItem
    {
        private string sourceFilePath;
        private string destinationFilePath;
        private ListViewItem listViewItem;

        /// <summary>
        /// Gets or sets full path to original file.
        /// </summary>
        public string SourceFilePath
        {
            get { return sourceFilePath; }
            set
            {
                if (sourceFilePath != value)
                {
                    sourceFilePath = value;

                    if (listViewItem != null && listViewItem.SubItems.Count >= 1)
                    {
                        listViewItem.SubItems[0].Text = value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets name of original file.
        /// </summary>
        public string SourceFileName
        {
            get 
            {
                string sourceFilePath = SourceFilePath;

                if (string.IsNullOrWhiteSpace(sourceFilePath))
                    return string.Empty;

                return Path.GetFileName(sourceFilePath);
            }
        }

        /// <summary>
        /// Gets or sets full path to destination file.
        /// </summary>
        public string DestinationFilePath
        {
            get { return destinationFilePath; }
            set
            {
                if (destinationFilePath != value)
                {
                    destinationFilePath = value;

                    if (listViewItem != null && listViewItem.SubItems.Count == 2)
                    {
                        listViewItem.SubItems[1].Text = DestinationFileName;
                    }
                }
            }
        }

        /// <summary>
        /// Gets name of destination file.
        /// </summary>
        public string DestinationFileName
        {
            get 
            {
                string destinationFilePath = DestinationFilePath;

                if (string.IsNullOrWhiteSpace(destinationFilePath))
                    return string.Empty;

                return Path.GetFileName(destinationFilePath);
            }
        }

        /// <summary>
        /// Gets <see cref="ListViewItem"/> presenting renamed file.
        /// </summary>
        public ListViewItem ListViewItem
        {
            get
            {
                if (listViewItem == null)
                {
                    string[] values;
                    if (Program.ShowFullFilePaths)
                        values = new string[] { SourceFilePath, DestinationFilePath };
                    else
                        values = new string[] { SourceFileName, DestinationFileName };

                    listViewItem = new ListViewItem(values);
                    listViewItem.Tag = this;
                }

                return listViewItem;
            }
        }

        /// <summary>
        /// Gets whether or not source file exists.
        /// </summary>
        /// <returns><c>true</c> if source file exists; <c>false</c> otherwise.</returns>
        public bool SourceFileExists()
        {
            if (string.IsNullOrWhiteSpace(SourceFilePath))
                return false;

            return File.Exists(SourceFilePath);
        }

        /// <summary>
        /// Gets whether or not destination file exists.
        /// </summary>
        /// <returns><c>true</c> if destination file exists; <c>false</c> otherwise.</returns>
        public bool DestinationFileExists()
        {
            if (string.IsNullOrWhiteSpace(DestinationFilePath))
                return false;

            return File.Exists(DestinationFilePath);
        }
    }
}
