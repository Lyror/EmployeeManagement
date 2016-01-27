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
	public partial class NewLocation : Form
	{
		public NewLocation()
		{
			InitializeComponent();
		}
		bool shown = false;
		List<Tuple<string, int, string>> list = new List<Tuple<string, int, string>>();

		RpcClient locationsClient = new RpcClient(Config.RpcConfigString, "Locations");

		private void dgLocations_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			int count = 0;
			foreach (DataGridViewRow row in dgLocations.Rows)
			{
				if (row.Cells[0].Value.ToString().ToUpper() == row.Cells[0].Value.ToString().ToUpper())
				{
					count++;
					break;
				}
			}
			if (count > 1)
			{
				MessageBox.Show("Diese Abteilung ist schon definiert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
			}
		}

		private void dgLocations_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			int id = Convert.ToInt32(locationsClient.CallSyncMethod("InsertLocation", Guid.NewGuid().ToString()));

			var rowIndex = dgLocations.Rows.IndexOf(e.Row);

			dgLocations.Rows[rowIndex].Tag = id;
		}

		private void dgLocations_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{

			locationsClient.CallSyncMethod("DeleteLocation", Convert.ToInt32(e.Row.Tag));
		}

		private void NewLocation_Load(object sender, EventArgs e)
		{
			Dictionary<int, string> departments = (Dictionary<int, string>)locationsClient.CallSyncMethod("GetLocations");
			foreach (var item in departments)
			{
				int index = dgLocations.Rows.Add(item.Value);
				dgLocations.Rows[index].Tag = item.Key;
			}
			shown = true;
		}

		private void dgLocations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (shown)
				locationsClient.CallSyncMethod("UpdateLocation", Convert.ToInt32(dgLocations.Rows[e.RowIndex].Tag ?? dgLocations.Rows[e.RowIndex + 1].Tag), dgLocations[e.ColumnIndex, e.RowIndex].Value.ToString());
		}

		private void btClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
