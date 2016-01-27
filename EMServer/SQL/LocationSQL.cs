using acadGraph.Libs.RpcWebLib;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	public class LocationSQL : SQL
	{
		public LocationSQL(string s)
			: base(s)
		{

		}

		[WebMethod]
		public Dictionary<int, string> GetLocations()
		{
			Dictionary<int, string> table = new Dictionary<int, string>();

			using (var command = Connection.GetCommand("SELECT * FROM location"))
			{
				using (var reader= command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Add(Convert.ToInt32(reader["id"]), reader["name"].ToString());
					}
				}
			}
			return table;
		}

		[WebMethod]
		public void UpdateLocation(int id, string newName)
		{
			using (DbCommand command = Connection.GetCommand("UPDATE location SET name = " + Connection.ParamMarker("var0") + " WHERE id = " + Connection.ParamMarker("var1")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = newName;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = id;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public int GetLoactionByName(string name)
		{
			using (DbCommand command = Connection.GetCommand("SELECT id FROM location WHERE name = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = name;
				return Convert.ToInt32(command.ExecuteScalar());
			}
		}

		[WebMethod]
		public int InsertLocation(string name)
		{
			using (DbCommand command = Connection.GetCommand("INSERT INTO location (name) VALUES (" + Connection.ParamMarker("var0") + ")"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = name;
				command.ExecuteNonQuery();
			}
			return GetLoactionByName(name);
		}

		[WebMethod]
		public void DeleteLocation(string newName)
		{
			using (DbCommand command = Connection.GetCommand("DELETE FROM location WHERE name = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = newName;
				command.ExecuteNonQuery();
			}
		}
	}
}
