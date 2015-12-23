using acadGraph.Libs.DBConnection.Connections;
using acadGraph.Libs.RpcWebLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	public abstract class SQL : IWebService
	{
		public SQL(String UdlStringOrFileString)
		{
			InitialzeConnection(UdlStringOrFileString);
		}

		protected static CustomConnection Connection { get; private set; }
		private String connectionString = null;

		private void InitialzeConnection(string UdlStringOrFileString)
		{
			ConnectionClass cc = new ConnectionClass();
			if (File.Exists(UdlStringOrFileString))
			{
				Connection = cc.CreateConnection(UdlStringOrFileString, true);
				connectionString = cc.ConnectionString;
			}
			else
			{
				Connection = cc.CreateConnection(UdlStringOrFileString, false);
				connectionString = cc.ConnectionString;
			}
			Connection.Open(cc.ConnectionString);
		}

		internal static void SetConnectionString(CustomConnection con)
		{
			Connection = con;
		}

		protected virtual void Finish()
		{
			Connection.Close();
		}
	}
}
