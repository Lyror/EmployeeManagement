using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acadGraph.Libs.RpcClientLib;
using EMLib.Employees;
using EMLib;

namespace EMClient
{
	public partial class EmployeeView : UserControl
	{
		public EmployeeView()
		{
			InitializeComponent();
		}

		public Control GetControl()
		{
			return this;
		}
		RpcClient client = new RpcClient(Config.RpcConfigString, "Test");

		List<int> deleteIdList = new List<int>();

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void tsbLoad_Click(object sender, EventArgs e)
		{
			deleteIdList.Clear();
			var result = client.CallSyncMethod("GetEmployees");
			EmployeeTable table = Serialize.FromBase64<EmployeeTable>(result.ToString());
			foreach (var row in table.Rows)
			{
				int index = dgEmployeeView.Rows.Add(row.FirstName, row.LastName, row.Address, row.Birthday, row.Email, 
					row.Phone, row.DateCount, row.HourCountPerDay, row.HourCountPerWeek, row.HolidaysPerYear);
				dgEmployeeView.Rows[index].Tag = row.Id;
			}
		}

		private void tsbSave_Click(object sender, EventArgs e)
		{
			dgEmployeeView.EndEdit();

			EmployeeTable table = new EmployeeTable();
			foreach (DataGridViewRow row in dgEmployeeView.Rows)
			{
				table.Rows.Add
				(
					new EmployeeRow()
						{
							Id = Convert.ToInt32(row.Tag),
							FirstName = row.Cells[0].Value.ToString(),
							LastName = row.Cells[1].Value.ToString(),
							Address = row.Cells[2].Value.ToString(),
							Birthday = DateTime.Parse(row.Cells[3].Value.ToString()),
							Email = row.Cells[4].Value.ToString(),
							Phone = row.Cells[5].Value.ToString(),
							DateCount = Convert.ToInt32(row.Cells[6].Value),
							HourCountPerDay = Convert.ToInt32(row.Cells[7].Value),
							HolidaysPerYear = Convert.ToInt32(row.Cells[8].Value)
						}
					);
			}


			client.CallSyncMethod("UpdateEmployee", Serialize.ToBase64(table));
			client.CallSyncMethod("DeleteEmployees", deleteIdList);
		}

		private void dgEmployeeView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			var row = dgEmployeeView.SelectedRows[0];
			MessageBox.Show(row.Tag.ToString());
		}

		private void dgEmployeeView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			deleteIdList.Add(Convert.ToInt32(e.Row.Tag));
		}

		private void tsbNewEmployee_Click(object sender, EventArgs e)
		{

		}
	}
}
