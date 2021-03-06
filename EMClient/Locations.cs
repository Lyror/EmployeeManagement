﻿using acadGraph.Libs.RpcClientLib;
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

		private void Locations_Load(object sender, EventArgs e)
		{
			var result = locationsGroupClient.CallSyncMethod("GetLocationsAndDepartments");

			foreach (var locItem in (Dictionary<string, Dictionary<string, bool>>)result)
			{
				lvLocations.Items.Add(locItem.Key).Tag = locItem.Value;
			}
		}

		object wait = new object();
		private void lvLocations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lvLocations.SelectedItems.Count > 0)
			{
				
				Dictionary<string, bool> item = (Dictionary<string, bool>)lvLocations.SelectedItems[0].Tag;

				Dictionary<string, bool> itemCopy = new Dictionary<string, bool>(item);

				clbDepartments.Items.Clear();

				lock (wait)
				{
					foreach (var departments in itemCopy)
					{
						clbDepartments.Items.Add(departments.Key, departments.Value);
					}
				}
			}
		}

		private void clbDepartments_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (lvLocations.SelectedItems.Count > 0 && e.CurrentValue.CompareTo(e.NewValue) != 0)
			{
				Dictionary<string, bool> item = (Dictionary<string, bool>)lvLocations.SelectedItems[0].Tag;
				item[clbDepartments.Items[e.Index].ToString()] = e.NewValue == 0 ? false : true;
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

		private void btClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
