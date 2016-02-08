using acadGraph.Libs.RpcClientLib;
using EMLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMClient
{
	public partial class Locations : Form
	{
		public Locations()
		{
			InitializeComponent();
		}

		RpcClient locationClient = new RpcClient(Config.RpcConfigString, "Locations");
		RpcClient locationsGroupClient = new RpcClient(Config.RpcConfigString, "LocationsGroup");

		List<Tuple<string, List<Tuple<string, bool>>>> mappingList = new List<Tuple<string, List<Tuple<string, bool>>>>();

		private void Locations_Load(object sender, EventArgs e)
		{
			var result = locationsGroupClient.CallSyncMethod("GetLocationsAndDepartments");

			lock(wait)
			{
				foreach (var item in (Dictionary<string, Dictionary<string, bool>>)result)
				{
					var checkedList = (from l in item.Value select new Tuple<string, bool>(l.Key, l.Value)).ToList();
					mappingList.Add
					(
						new Tuple<string, List<Tuple<string, bool>>>(item.Key, checkedList)
					);

					lvLocations.Items.Add(item.Key).Tag = checkedList;
				}
			}
		}

		object wait = new object();
		private void lvLocations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvLocations.SelectedItems.Count > 0)
			{
				List<Tuple<string, bool>> item = (List<Tuple<string,bool>>)lvLocations.SelectedItems[0].Tag;
				clbDepartments.Items.Clear();

				lock (wait)
				{
					foreach (var departments in item)
					{
						clbDepartments.Items.Add(departments.Item1, departments.Item2);
					}
				}
			}
		}

		private void clbDepartments_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (lvLocations.SelectedItems.Count > 0 && e.CurrentValue.CompareTo(e.NewValue) != 0)
			{
				lock(wait)
					{
					List<Tuple<string, bool>> item = (List<Tuple<string, bool>>)lvLocations.SelectedItems[0].Tag;
					// = e.NewValue == 0 ? false : true;
				}
			}
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			Dictionary<string, List<string>> items = new Dictionary<string, List<string>>();

			foreach (ListViewItem locItem in lvLocations.Items)
			{
				items.Add(locItem.Text, (from l in ((Dictionary<string, bool>)locItem.Tag) where l.Value == true select l.Key).ToList());
			}

			locationsGroupClient.CallSyncMethod("DeleteLocationsGroup");
			locationsGroupClient.CallSyncMethod("InsertLocationGroupByTable", items);
		}
	}
}
