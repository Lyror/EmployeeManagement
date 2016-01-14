using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLib
{
	[Serializable]
	[Editor(typeof(CheckedListBoxEditor), typeof(System.Drawing.Design.UITypeEditor))]
	public class CheckedListBox
	{
		public int EmployeeId { get; set; }
		public Dictionary<string, bool> Items { get; set; }

		public List<string> GetCheckedItems()
		{
			List<string> items = new List<string>();

			foreach (var item in Items)
			{
				if (item.Value)
					items.Add(item.Key);
			}
			return items;
		}

		public override string ToString()
		{
			return "Auflistung";
		}
	}
}
