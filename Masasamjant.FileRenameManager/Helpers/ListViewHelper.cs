using System.Drawing;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    internal static class ListViewHelper
    {
        internal static void DrawCustomHeader(ListView listView, DrawListViewColumnHeaderEventArgs e)
        {
            ColumnHeader columnHeader = listView.Columns[e.ColumnIndex];

            // Use dark gray background on column headers.
            e.Graphics.FillRectangle(Brushes.DarkGray, e.Bounds);

            // Draw text to vertical center.
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;

            // Use original text and font.
            e.Graphics.DrawString(columnHeader.Text, e.Font, Brushes.White, e.Bounds, sf);
        }
    }
}
