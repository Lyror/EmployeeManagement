using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acadGraph.Libs.RpcClientLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using EMLib;

namespace EmployeeManagement
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RpcClient rpcClient = new RpcClient("http://localhost:8081/rpc", "Test");
			var result = rpcClient.CallSyncMethod("GetEmployees");
			var s = Serialize.FromBase64<EMLib.Employees.EmployeeTable>(result.ToString());
			MessageBox.Show(s.Rows.First().Items.FirstOrDefault(c => c.Column.ToUpper() == "FirstName".ToUpper()).Value.ToString());
		}

		public static T DeserializeFromBase64String<T>(String str)
		{
			using (var ms = new MemoryStream(Convert.FromBase64String(str)))
			{
				ms.Seek(0, SeekOrigin.Begin);
				return (T)new BinaryFormatter().Deserialize(ms);
			}
		}
	}
}
