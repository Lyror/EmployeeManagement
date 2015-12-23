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
		public object GetDepartmentGroup(string StringRow)
		{
			DepartmentGroupTable table = new DepartmentGroupTable();
			DepartmentGroupRow row = EMLib.Serialize.FromBase64<DepartmentGroupRow>(StringRow);
			using (DbCommand command = Connection.GetCommand("INSERT INTO DepartmentGroup (EmployeeId, DepartmentId) Values ( " + Connection.ParamMarker("var0") + ", " + Connection.ParamMarker("var1") + " )"))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = row.EmployeeId;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.Int32).Value = row.DepartmentId;
				command.ExecuteNonQuery();
			}
			return EMLib.Serialize.ToBase64(table);
		}
	}
}
