using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boomkwekerij.Sorting
{
	class ListViewItemComparer : IComparer
	{
		private int col;
		private SortOrder sortOrder;

		public ListViewItemComparer()
		{
			col = 0;
		}
		public ListViewItemComparer(int column, SortOrder sortOrder)
		{
			col = column;
			this.sortOrder = sortOrder;
		}
		public int Compare(object x, object y)
		{
			if(sortOrder == SortOrder.Ascending)
			{
				return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
			}
			return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
		}
	}
}
