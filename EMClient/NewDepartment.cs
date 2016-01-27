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
	public partial class NewDepartment : Form
	{
		public NewDepartment()
		{
			InitializeComponent();
		}
		bool shown = false;
		List<Tuple<string, int, string>> list = new List<Tuple<string, int, string>>();

		RpcClient departmentClient = new RpcClient(Config.RpcConfigString, "Departments");

		private void dgDepartmentss_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			int count = 0;
			foreach (DataGridViewRow row in dgDepartments.Rows)
			{
				if (row.Cells[0].Value.ToString().ToUpper() == row.Cells[0].Value.ToString().ToUpper())
				{
					count++;
					break;
				}
			}
			if(count > 1)
			{
				MessageBox.Show("Diese Abteilung ist schon definiert", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
			}
		}

		private void dgDepartmentss_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			int id = Convert.ToInt32(departmentClient.CallSyncMethod("InsertDepartment", Guid.NewGuid().ToString()));

			var rowIndex = dgDepartments.Rows.IndexOf(e.Row);

			dgDepartments.Rows[rowIndex].Tag = id;
		}

		private void dgDepartmentss_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			departmentClient.CallSyncMethod("UpdateDepartmentName", Convert.ToInt32(e.Row.Tag), e.Row.Cells[0].Value.ToString());

			departmentClient.CallSyncMethod("DeleteDepartment", Convert.ToInt32(e.Row.Tag));
		}

		private void NewDepartment_Load(object sender, EventArgs e)
		{
			Dictionary<int, string> departments = (Dictionary<int, string>)departmentClient.CallSyncMethod("GetDepartments");
			foreach (var item in departments)
			{
				int index= dgDepartments.Rows.Add(item.Value);
				dgDepartments.Rows[index].Tag = item.Key;
			}
			shown = true;
		}

		private void dgDepartmentss_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (shown)
				departmentClient.CallSyncMethod("UpdateDepartmentName", Convert.ToInt32(dgDepartments.Rows[e.RowIndex].Tag??dgDepartments.Rows[e.RowIndex+1].Tag), dgDepartments[e.ColumnIndex, e.RowIndex].Value.ToString());
		}

		private void btClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
