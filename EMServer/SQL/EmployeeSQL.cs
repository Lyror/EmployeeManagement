using acadGraph.Libs.DBConnection.Connections;
using acadGraph.Libs.RpcWebLib;
using EMLib;
using EMLib.Employees;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EMServer.SQL
{
	public class EmployeeSQL : SQL, IWebService
	{
		public EmployeeSQL(string UdlStringOrFileString)
			: base(UdlStringOrFileString)
		{

		}

		private const string employeeView = "employeeView";

		[WebMethod]
		public string GetEmployees()
		{
			string sql = "select * from employeeView as ev " +
							"inner join timeManagement as tm on ev.id = tm.id " +
							"inner join deparmentGroup as dg on ev.id = dg.employeeId " +
							"inner join departments as d on dg.departmentId = d.id " +
							"inner join location as l on d.locationId = l.id";

			EmployeeTable table = new EmployeeTable();
			using (var command = Connection.GetCommand(sql))
			{
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						table.Rows.Add
						(
							new EmployeeRow()
							{
								 FirstName = reader["firstName"].ToString(),
								 LastName = reader["lastName"].ToString(),
								 Address = reader["adress"].ToString(),
								 Birthday = DateTime.Parse(reader["birthday"].ToString()),
								 Email = reader["email"].ToString(),
								 Phone = reader["phone"].ToString(),
								 DateCount = Convert.ToInt32(reader["dateCount"]),
								 HourCountPerDay = Convert.ToInt32(reader["hourCountPerDay"]),
								 HolidaysPerYear = Convert.ToInt32(reader["holidaysPerYear"])
							}
						);
					}
				}
			}
			return Serialize.ToBase64(table);
		}


		[WebMethod]
		public string GetEmployee(int id)
		{
			string sql = "SELECT * FROM " + employeeView + " WHERE id = " + id;

			EmployeeRow row = null;
			using (var command = Connection.GetCommand(sql))
			{
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						row = new EmployeeRow()
							{
								FirstName = reader["firstName"].ToString(),
								LastName = reader["lastName"].ToString(),
								Address = reader["adress"].ToString(),
								Birthday = DateTime.Parse(reader["birthday"].ToString()),
								Email = reader["email"].ToString(),
								Phone = reader["phone"].ToString(),
								DateCount = Convert.ToInt32(reader["dateCount"]),
								HourCountPerDay = Convert.ToInt32(reader["hourCountPerDay"]),
								HolidaysPerYear = Convert.ToInt32(reader["holidaysPerYear"])
							};
					}
				}
			}
			return Serialize.ToBase64(row);
		}

		[WebMethod]
		public void InsertEmployee(string em)
		{
			Connection.BeginTransaction();
			EmployeeRow row = Serialize.FromBase64<EmployeeRow>(em);

			StringBuilder sb = new StringBuilder("INSERT INTO employees (firstName, lastName, adress, birthday, email, phone,dateCount, hourCountPerDay, holidaysPerYear) Values (");

			int fieldCount = 9;

			for (int i = 0; i < fieldCount; i++)
			{
				sb.Append(Connection.ParamMarker("var" + i));

				if (i + 1 < fieldCount)
					sb.Append(',');
			}
			
			using (DbCommand command = Connection.GetCommand(sb.ToString()))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = row.FirstName;
				Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = row.LastName;
				Connection.AddParam(command, Connection.ParamMarker("var2"), System.Data.DbType.String).Value = row.Address;
				Connection.AddParam(command, Connection.ParamMarker("var3"), System.Data.DbType.DateTime).Value = row.Birthday;
				Connection.AddParam(command, Connection.ParamMarker("var4"), System.Data.DbType.String).Value = row.Email;
				Connection.AddParam(command, Connection.ParamMarker("var5"), System.Data.DbType.String).Value = row.Phone;
				Connection.AddParam(command, Connection.ParamMarker("var6"), System.Data.DbType.Int32).Value = row.DateCount;
				Connection.AddParam(command, Connection.ParamMarker("var7"), System.Data.DbType.Int32).Value = row.HourCountPerDay;
				Connection.AddParam(command, Connection.ParamMarker("var8"), System.Data.DbType.Int32).Value = row.HolidaysPerYear;

				command.ExecuteNonQuery();
			}
		}
	}
}
