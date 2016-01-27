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
			InitializeComponent();
			Clb = clb;
			foreach (var item in clb.Items)
			{
				clbChoise.Items.Add(item.Key, item.Value);
			}
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			DgClient.CallSyncMethod("DeleteDepartmentGroup", Clb.EmployeeId);
			Clb.Items.Clear();
			for (int i = 0; i < clbChoise.Items.Count; i++)
			{
				Clb.Items.Add(clbChoise.Items[i].ToString(), false);
			}
			foreach (var item in clbChoise.CheckedItems)
			{
				Clb.Items[item.ToString()] = true;
				var id = DClient.CallSyncMethod("GetDepartmentByName", item.ToString());
				DgClient.CallSyncMethod("InsertDepartmentGroup", Clb.EmployeeId, Convert.ToInt32(id));
			}
		}

		private void FrmCheckedListBox_Shown(object sender, EventArgs e)
		{
			MessageBox.Show("Dies ist eine nicht fertige Version eines alten Entwurfs und\r\n dient nur zur Skizze des neuen Entwurfs welcher in dieser Client-Version nicht verfügbar ist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
