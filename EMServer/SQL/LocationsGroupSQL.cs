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
		public Dictionary<string, Dictionary<string, bool>> GetLocationsAndDepartments()
		{
			Dictionary<string, Dictionary<string, bool>> items = new Dictionary<string, Dictionary<string, bool>>();

			using (var command = Connection.GetCommand("SELECT d.name as 'department', l.name as 'location', " +
														"ISNULL((SELECT CASE WHEN lg.id > 0 then 1 end FROM locationsGroup as lg where " + 
														"lg.departmentId = d.id and lg.locationId = l.id), 0) as hasRight FROM departments as d, location as l " +
														"order by l.name, d.name"))
			{
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						if (items.ContainsKey(reader["location"].ToString()))
						{
							items[reader["location"].ToString()].Add(reader["department"].ToString(), Convert.ToBoolean(reader["hasRight"]));
						}
						else
						{
							items.Add(reader["location"].ToString(), new Dictionary<string, bool>() { {reader["department"].ToString(), Convert.ToBoolean(reader["hasRight"])}});
						}
					}
				}
			}
			return items;
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
						Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = location.Key;
						Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = department;
						command.ExecuteNonQuery();
						command.Parameters.Clear();
					}
				}
			}
		}

		[WebMethod]
		public void DeleteLocationsGroup()
		{
			using (DbCommand command = Connection.GetCommand("DELETE FROM locationsGroup"))
			{
				command.ExecuteNonQuery();
			}
		}
	}
}
