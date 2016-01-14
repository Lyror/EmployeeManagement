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
	public partial class NewEmployee : Form
	{
		public NewEmployee()
		{
			InitializeComponent();
		}

		private void btClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		public String FirstName { get; private set; }
		public String LastName { get; private set; }
		private void btSave_Click(object sender, EventArgs e)
		{
			FirstName = tbFirstName.Text;
			LastName = tbLastName.Text;
		}

		private void tbFirstName_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(tbFirstName.Text) && !String.IsNullOrEmpty(tbLastName.Text))
				btSave.Enabled = true;
			else
				btSave.Enabled = false;
		}

		private void tbLastName_TextChanged(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(tbFirstName.Text) && !String.IsNullOrEmpty(tbLastName.Text))
				btSave.Enabled = true;
			else
				btSave.Enabled = false;
		}
	}
}
