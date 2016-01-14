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
		public List<string> GetEmployeeDepartments(object employeeIdOrEmail)
		{
			List<string> items = new List<string>();
			using (DbCommand command = Connection.GetCommand(""))
			{
				string sql = null;
				int result = 0;
				if (int.TryParse(employeeIdOrEmail.ToString(), out result))
				{
					sql = "select d.name from departmentGroup as dg " +
							"INNER JOIN departments as d on dg.departmentId = d.id " +
							"where dg.employeeId = " + Connection.ParamMarker("var0");
					Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = Convert.ToInt32(employeeIdOrEmail);

				}
				else
				{
					sql = "select d.name from departmentGroup as dg " +
							"INNER JOIN departments as d on dg.departmentId = d.id " +
							"inner join employees as e on dg.employeeId = e.id " +
							"where e.email = " + Connection.ParamMarker("var0");
					Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = employeeIdOrEmail.ToString();
				}
				command.CommandText = sql;

				using (DbDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						items.Add(reader[0].ToString());
					}
				}
			}

			return items;
		}

		[WebMethod]
		public void InsertDepartmentGroup(int employeeId, string departmentId)
		{
			using (DbCommand command = Connection.GetCommand("INSERT INTO departmentGroup (employeeId, departmentId) Values ( " + Connection.ParamMarker("var0") + ", " + Connection.ParamMarker("var1") + " )"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = employeeId;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = departmentId;
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
