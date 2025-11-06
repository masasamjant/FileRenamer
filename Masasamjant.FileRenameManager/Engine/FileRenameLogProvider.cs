using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masasamjant.FileRenameManager
{
    public class FileRenameLogProvider
    {
        public FileRenameLogProvider(FileRenameLog log)
        {
            Log = log;
        }

        public static FileRenameLogProvider Current { get; internal set; }

        public FileRenameLog Log { get; }
    }
}
