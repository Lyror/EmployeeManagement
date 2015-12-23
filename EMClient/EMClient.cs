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
	public partial class EMClient : Form
	{
		public EMClient()
		{
			InitializeComponent();
		}

		private void EMClient_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Test");
		}
	}
}
