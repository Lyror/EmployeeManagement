using acadGraph.Libs.RpcWebLib;
using EMLib.Locations;
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
		public string GetLocations()
		{
			LocationTable table = new LocationTable();

			using (var command = Connection.GetCommand("SELECT * FROM location"))
			{
				using (var reader= command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Rows.Add
						(
							new LocationRow()
							{
								Name = reader["name"].ToString()
							}
						);
					}
				}
			}
			return EMLib.Serialize.ToBase64(table);
		}

		[WebMethod]
		public string UpdateLocation(string newName)
		{
			LocationTable table = new LocationTable();

			using (var command = Connection.GetCommand("SELECT * FROM location"))
			{
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Rows.Add
						(
							new LocationRow()
							{
								Name = reader["name"].ToString()
							}
						);
					}
				}
			}
			return EMLib.Serialize.ToBase64(table);
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
