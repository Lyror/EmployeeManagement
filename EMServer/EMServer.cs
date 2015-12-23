using acadGraph.Libs.DBConnection.Connections;
using acadGraph.Libs.RpcWebLib.HttpServerWrapper;
using ADODB;
using HttpServer;
using HttpServer.Sessions;
using MSDASC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMServer
{
	public partial class EMServer : Form
	{
		private WebServer server;

		private String ConnectionString = null;

		public EMServer()
		{
			InitializeComponent();

			server = new WebServer();
			ConnectionString = ConfigLoader.LoadConnectionString();
		}

		private void btServerStart_Click(object sender, EventArgs e)
		{
			btServerStop.Enabled = true;
			btServerStart.Enabled = false;
			btOption.Enabled = false;
			pbStatus.Image = Properties.Resources.ampel_200c;
			server.ConnectionString = ConnectionString ?? ConfigLoader.LoadConnectionString();
			server.Start();
		}

		private void btServerStop_Click(object sender, EventArgs e)
		{
			btServerStop.Enabled = false;
			btServerStart.Enabled = true;
			btOption.Enabled = true;
			pbStatus.Image = Properties.Resources.ampel_200a;
			server.Stop();
		}

		private void btSetConnectionString_Click(object sender, EventArgs e)
		{
			DataLinks mydlg = new DataLinks();

			if (ConnectionString == null)
			{
				var connectionStringAdo = (Connection)mydlg.PromptNew();
				ConnectionString = connectionStringAdo.ConnectionString;
			}
			else
			{
				Connection con = new Connection();
				con.ConnectionString = ConnectionString;
				object x = con;
				if (mydlg.PromptEdit(ref x))
				{
					con = x as Connection;
				}
				ConnectionString = con.ConnectionString;
			}

			ConfigLoader.Save(ConnectionString);
		}
	}
}
