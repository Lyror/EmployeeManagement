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
	public partial class EmployeeView : UserControl, IPages
	{
		public EmployeeView()
		{
			InitializeComponent();
		}

		public Control GetControl()
		{
			return this;
		}
		RpcClient client = new RpcClient("http://nb72:8081/rpc", "Test");

		private void button1_Click(object sender, EventArgs e)
		{
			var result = client.CallSyncMethod("GetEmployees");
			EmployeeTable table = Serialize.FromBase64<EmployeeTable>(result.ToString());
			table.Rows.First().Items.First();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
