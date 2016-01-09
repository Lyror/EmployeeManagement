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
			
		private IPages Page;
		public EMClient()
		{
			InitializeComponent();
		}

		private void tvNavigation_AfterSelect(object sender, TreeViewEventArgs e)
		{
			switch (e.Node.Text.ToUpper())
			{
				case "MITARBEITER":
					Page = new EmployeeView();
					Page.GetControl().Dock = DockStyle.Fill;
					break;
				default:
					pControls.Controls.Remove(Page.GetControl());
					return;
			}
			pControls.Controls.Add(Page.GetControl());
		}
	}
}
