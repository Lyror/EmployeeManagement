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
		public object GetDepartments()
		{
			DepartmentTable table = new DepartmentTable();

			using (DbCommand command = Connection.GetCommand("SELECT * FROM departments"))
			{
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Rows.Add
						(
							new DepartmentRow()
							{
								LocationId = Convert.ToInt32(reader["locationId"]),
								Name = reader["name"].ToString()
							}
						);
					}
				}
			}
			return EMLib.Serialize.ToBase64(table);
		}


		[WebMethod]
		public void InsertDepartment(string stringRow)
		{
			var row = EMLib.Serialize.FromBase64<DepartmentRow>(stringRow);

			using (DbCommand command = Connection.GetCommand("INSERT INTO departments (locationId, name) Values (" + Connection.ParamMarker("var0") + ", " + Connection.ParamMarker("var1") + ")"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = row.LocationId;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = row.Name;
				command.ExecuteNonQuery();
			}
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
