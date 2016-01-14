using acadGraph.Libs.RpcWebLib;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	public class LocationsGroupSQL : SQL
	{
		public LocationsGroupSQL(string s) : base(s)
		{

		}
		[WebMethod]
		public void GetLocationsAndDepartments()
		{
			Dictionary<string, List<string>> items = new Dictionary<string, List<string>>();

			using (var command = Connection.GetCommand("select  l.name as location, d.name as department from locationsGroup as lg " +
														"inner join departments as d on lg.departmentId = d.id " +
														"inner join location as l on lg.locationId = l.id " +
														"order by l.name, d.name"))
			{
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						if (items.ContainsKey(reader["location"].ToString()))
						{
							items[reader["location"].ToString()].Add(reader["department"].ToString());
						}
						else
						{
							items.Add(reader["location"].ToString(), new List<string>() { reader["department"].ToString() });
						}
					}
				}
			}
		}

		[WebMethod]
		public void InsertLocationGroupById(int locationId, int departmentId)
		{
			using (var command = Connection.GetCommand("INSET INTO locationsGroup (locationId, departmentId) Values (" + Connection.ParamMarker("var0") + ", " + Connection.ParamMarker("var1") + ")"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = locationId;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = departmentId;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public void InsertLocationGroupByName(string locationName, string departmentName)
		{
			using (var command = Connection.GetCommand("INSERT INTO locationsGroup (locationId, departmentId) Values ((SELECT id from location WHERE name = " +
				 Connection.ParamMarker("var0") + "), (SELECT id FROM departments WHERE name = " + Connection.ParamMarker("var1") + "))"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = locationName;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = departmentName;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public void InsertLocationGroupByTable(Dictionary<string, List<string>> items)
		{
			using (var command = Connection.GetCommand("INSERT INTO locationsGroup (locationId, departmentId) Values ((SELECT id from location WHERE name = " +
				 Connection.ParamMarker("var0") + "), (SELECT id FROM departments WHERE name = " + Connection.ParamMarker("var1") + "))"))
			{
				foreach (var location in items)
				{
					foreach (var department in location.Value)
					{
						Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = location.Key;
						Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = department;
						command.ExecuteNonQuery();
						command.Parameters.Clear();
					}
				}
			}
		}

		[WebMethod]
		public void DeleteLocationsGroup()
		{
			using (DbCommand command = Connection.GetCommand("DELETE FROM location"))
			{
				command.ExecuteNonQuery();
			}
		}
	}
}
