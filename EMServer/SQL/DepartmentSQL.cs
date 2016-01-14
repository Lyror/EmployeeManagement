using acadGraph.Libs.RpcWebLib;
using EMLib.Departments;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	class DepartmentSQL: SQL, IWebService
	{
		public DepartmentSQL(string s) : base(s)
		{

		}
		[WebMethod]
		public Dictionary<int, string> GetDepartments()
		{
			Dictionary<int, string> table = new Dictionary<int, string>();

			using (DbCommand command = Connection.GetCommand("SELECT * FROM departments"))
			{
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Add(Convert.ToInt32(reader["locationId"]), reader["name"].ToString());
					}
				}
			}
			return table;
		}

		[WebMethod]
		public string GetDepartmentById(int id)
		{
			using (DbCommand command = Connection.GetCommand("SELECT name FROM departments WHERE id = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = id;
				return command.ExecuteScalar().ToString();
			}
		}


		[WebMethod]
		public int GetDepartmentByName(string name)
		{
			using (DbCommand command = Connection.GetCommand("SELECT id FROM departments WHERE name = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = name;
				return Convert.ToInt32(command.ExecuteScalar());			
			}
		}

		[WebMethod]
		public Dictionary<string, bool> GetDepartmentsByEmployeeId(int id)
		{
			Dictionary<string, bool> table = new Dictionary<string, bool>();
			using (DbCommand command = Connection.GetCommand("select d.name, dg.id, e.firstName, (CASE WHEN dg.id is not null then 1 else 0 end) as hasRight " +
																"from employees as e " +
																"inner join departmentGroup as dg on e.id = dg.employeeId " +
																"right join departments as d on dg.departmentId = d.id"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = id;
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Add(reader["name"].ToString(), Convert.ToInt32(reader["hasRight"].ToString()) == 0 ? false : true);
					}
				}
			}
			return table;
		}

		[WebMethod]
		public int InsertDepartment(string name)
		{

			using (DbCommand command = Connection.GetCommand("INSERT INTO departments (name) Values (" + Connection.ParamMarker("var0") + ")"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = name;
				command.ExecuteNonQuery();
			}
			return GetDepartmentByName(name);
		}

		[WebMethod]
		public void UpdateDepartmentName(string newName)
		{
			using (DbCommand command = Connection.GetCommand("UPDATE departments SET name = " + Connection.ParamMarker("var0") + ""))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = newName;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public void DeleteDepartment(string stringRow)
		{
			var row = EMLib.Serialize.FromBase64<DepartmentRow>(stringRow);

			using (DbCommand command = Connection.GetCommand("DELETE FROM departments WHERE name = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = row.Name;
				command.ExecuteNonQuery();
			}
		}
	}
}
