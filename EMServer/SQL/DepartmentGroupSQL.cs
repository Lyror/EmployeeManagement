using acadGraph.Libs.RpcWebLib;
using EMLib.DepartmentGroup;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	public class DepartmentGroupSQL : SQL, IWebService
	{
		public DepartmentGroupSQL(string s)
			: base(s)
		{

		}
		[WebMethod]
		public object GetDepartmentGroup()
		{
			DepartmentGroupTable table = new DepartmentGroupTable();

			using (DbCommand command = Connection.GetCommand("SELECT * FROM departmentGroup"))
			{
				using (DbDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Rows.Add
						(
							new DepartmentGroupRow()
							{
								EmployeeId = Convert.ToInt32(reader["employeeId"]),
								DepartmentId = Convert.ToInt32(reader["departmentId"]),
							}
						);
					}
				}
			}
			return EMLib.Serialize.ToBase64(table);
		}

		[WebMethod]
		public Dictionary<string, Dictionary<string, bool>> GetEmployeeDepartments(int employeeId)
		{
			Dictionary<string, Dictionary<string, bool>> locations = new Dictionary<string,Dictionary<string,bool>>();

			using (DbCommand command = Connection.GetCommand("SELECT l.name as 'locationName', d.name as 'departmentName', " +
																"ISNULL((SELECT CASE WHEN dg.id > 0 then 1 end FROM departmentGroup as dg where dg.employeeId = e.id and dg.departmentId = lg.id), 0) as hasRight " +
																"FROM employees as e, locationsGroup as lg, location as l, departments as d " +
																"WHERE e.id = " + Connection.ParamMarker("var0")  + " and (lg.locationId = l.id and d.id = lg.departmentId)"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = employeeId;
				using (DbDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Dictionary<string, bool> departments;

						if(locations.TryGetValue(reader["locationName"].ToString(), out departments))
						{
							departments.Add(reader["departmentName"].ToString(), Convert.ToInt32(reader["hasRight"].ToString()) == 0 ? false : true);
						}
						else
						{
							if(departments == null)
								departments = new Dictionary<string, bool>();
							departments.Add(reader["departmentName"].ToString(), Convert.ToInt32(reader["hasRight"].ToString()) == 0 ? false : true);
							locations.Add(reader["locationName"].ToString(), departments);
						}
					}
				}
			}

			return locations;
		}

		[WebMethod]
		public void InsertDepartmentGroupById(int employeeId, string departmentId)
		{
			using (DbCommand command = Connection.GetCommand("INSERT INTO departmentGroup (employeeId, departmentId) Values ( " + Connection.ParamMarker("var0") + ", " + Connection.ParamMarker("var1") + " )"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = employeeId;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = departmentId;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public void InsertDepartmentGroupByName(int employeeId, string locationName, string departmentName)
		{
			using (DbCommand command = Connection.GetCommand("INSERT INTO departmentGroup (employeeId, departmentId) Values (" + Connection.ParamMarker("var0") + ", " +
								"(SELECT id FROM locationsGroup as lg where lg.locationId = (SELECT id from location where name = " + Connection.ParamMarker("var1") + ") and lg.departmentId = " +
								"(SELECT id from departments where name = " + Connection.ParamMarker("var2") + ")))"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = employeeId;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = locationName;
				Connection.AddParam(command, Connection.ParamMarker("var2"), System.Data.DbType.String).Value = departmentName;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public void DeleteDepartmentGroup(int employeeId)
		{
			using (DbCommand command = Connection.GetCommand("DELETE FROM departmentGroup WHERE EmployeeId = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = employeeId;
				command.ExecuteNonQuery();
			}
		}
	}
}
