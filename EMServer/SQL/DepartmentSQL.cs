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
						table.Add(Convert.ToInt32(reader["id"]), reader["name"].ToString());
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
			string sql = null;
			switch (Connection.DBType)
			{
				case acadGraph.Libs.ConnectionConfig.DBTypes.Access:
					throw new NotImplementedException("Access not Supported");
					//sql = "SELECT e.firstName, d.name, IIf(NZ((SELECT dg.Id FROM departmentGroup as dg " +
					//		"where dg.employeeId = e.id and dg.departmentId = d.id)) > 0, '1', '0') AS hasRight " +
					//		"FROM employees AS e, departments AS d " + 
					//		"WHERE e.id = ";
					//break;
				case acadGraph.Libs.ConnectionConfig.DBTypes.SQLServer:
					sql = "SELECT e.firstName, d.name, " +
							"ISNULL((SELECT CASE WHEN dg.id > 0 then 1 end FROM departmentGroup as dg " +
							"where dg.employeeId = e.id and dg.departmentId = d.id), 0) as hasRight FROM employees as e, departments as d " +
							"WHERE e.id = ";
					break;
			}

			Dictionary<string, bool> table = new Dictionary<string, bool>();
			using (DbCommand command = Connection.GetCommand(sql + Connection.ParamMarker("var0")))
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
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = name;
				command.ExecuteNonQuery();
			}
			return GetDepartmentByName(name);
		}

		[WebMethod]
		public void UpdateDepartmentName(int id, string newName)
		{
			using (DbCommand command = Connection.GetCommand("UPDATE departments SET name = " + Connection.ParamMarker("var0") + " WHERE id = " + Connection.ParamMarker("var1")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = newName;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = id;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public void DeleteDepartment(int id)
		{
			using (DbCommand command = Connection.GetCommand("DELETE FROM departments WHERE id = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = id;
				command.ExecuteNonQuery();
			}
		}
	}
}
