using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    /// <summary>
    /// Helper clas to get selected files based on settings.
    /// </summary>
    internal static class FileSelectionHelper
    {
        /// <summary>
        /// Gets selected files of specified file open dialog. This excludes those extensions that user has
        /// set in settings.
        /// </summary>
        /// <param name="dialog">The file open dialog.</param>
        /// <returns>A array of suitable files.</returns>
        public static string[] GetSelectedFiles(OpenFileDialog dialog)
        {
            if (dialog.FileNames.Length > 1)
                return GetSelectedFiles(dialog.FileNames);
            else
                return GetSelectedFiles(new[] { dialog.FileName });
        }

        /// <summary>
        /// Gets selected files from specified file path array. This excludes those extensions that user has
        /// set in settings.
        /// </summary>
        /// <param name="files">The original file paths array.</param>
        /// <returns>A array of suitable files.</returns>
        public static string[] GetSelectedFiles(string[] files)
        {
            if (files == null || files.Length == 0)
                return new string[0];

            // Get extensions that should be excluded based on settings.
            string[] excludeExtensions = GetExcludeExtensions();

            // If there is something to exclude, then return only those where extension not excluded.
            if (excludeExtensions.Length > 0)
                return files.Where(f => Array.IndexOf(excludeExtensions, Path.GetExtension(f)) < 0)
                            .ToArray();

            return files;
        }

        private static string[] GetExcludeExtensions()
        {
            Properties.Settings settings = Properties.Settings.Default;

            if (!string.IsNullOrWhiteSpace(settings.ExcludeFileExtension))
            {
                string[] extensions = settings.ExcludeFileExtension.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (extensions.Length > 0)
                    return extensions.Select(ex => ex.Trim())
                                     .Where(ex => !string.IsNullOrWhiteSpace(ex))
                                     .Select(ex => ex.StartsWith(".")  ? ex : "." + ex)
                                     .ToArray();
            }

            return new string[0];
        }
    }
}
