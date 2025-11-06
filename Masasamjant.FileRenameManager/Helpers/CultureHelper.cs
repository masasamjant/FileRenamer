using System.Globalization;

namespace Masasamjant.FileRenameManager
{
    internal static class CultureHelper
    {
        private const string FinnishCultureName = "fi-FI";

        internal static bool IsFinnishCulture
        {
            get { return CultureInfo.CurrentUICulture.Name == FinnishCultureName; }
        }
    }
}
