using acadGraph.Libs.RpcClientLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMLib
{
	[Serializable]
	public partial class FrmCheckedListBox : Form
	{
		CheckedListBox Clb;

		RpcClient DgClient = new RpcClient(Config.RpcConfigString, "DepartmentGroup");
		RpcClient DClient = new RpcClient(Config.RpcConfigString, "Departments");

		public FrmCheckedListBox(CheckedListBox clb)
		{
			this.Clb = clb;
			InitializeComponent();
			var locations = DgClient.CallSyncMethod("GetEmployeeDepartments", clb.EmployeeId);

			foreach (var location in (Dictionary<string, Dictionary<string, bool>>)locations)
			{
				lvMapping.Groups.Add(location.Key, location.Key);
			}


			foreach (var location in (Dictionary<string, Dictionary<string, bool>>)locations)
			{
				foreach (var department in location.Value)
				{
					var item = lvMapping.Items.Add(new ListViewItem()
						{
							Text = department.Key,
							Name = department.Key,
							Checked = department.Value
						});
					item.Group = lvMapping.Groups[location.Key];
				}
			}
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			DgClient.CallSyncMethod("DeleteDepartmentGroup", Clb.EmployeeId);

			foreach (ListViewItem item in lvMapping.Items)
			{
				if(item.Checked)
				{
					DgClient.CallSyncMethod("InsertDepartmentGroupByName", Clb.EmployeeId, item.Group.Header, item.Text);
				}
			}
		}

		private void lvMapping_ItemChecked(object sender, ItemCheckedEventArgs e)
		{

		}
	}
}
