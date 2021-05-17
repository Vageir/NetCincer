using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NetCincer
{
    internal class ListViewItemComparer : IComparer
    {
        private Regex r = new Regex("^\\d\\d\\d\\d-\\d\\d-\\d\\d \\d\\d:\\d\\d$");
        private int col;
        private SortOrder order;

        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        public int Compare(object x, object y) {
            int returnVal = 0;
            try {
                if (r.IsMatch(((ListViewItem)x).SubItems[0].Text)) {
                    System.DateTime firstDate = DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
                    System.DateTime secondDate = DateTime.Parse(((ListViewItem)y).SubItems[col].Text);
                    returnVal = DateTime.Compare(firstDate, secondDate);
                }
                else
                {
                    returnVal = string.Compare(((ListViewItem)x).SubItems[col].Text,
                        ((ListViewItem)y).SubItems[col].Text);
                    if (order == SortOrder.Descending)
                    {
                        returnVal *= -1;
                    }
                }
                return returnVal;

            }
            catch
            {
                return 0;
            }
        }
    }
}