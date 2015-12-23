using acadGraph.Libs.RpcWebLib;
using EMLib.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	public class LocationSQL : SQL
	{
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
	}
}
