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

		[WebMethod]
		public string GetEmployees()
		{
			string sql = "select * from employees";

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
								Id = Convert.ToInt32(reader["id"]),
								FirstName = reader["firstName"] == null ? String.Empty : reader["firstName"].ToString(),
								LastName = reader["lastName"] == null ? String.Empty : reader["lastName"].ToString(),
								Adress = reader["adress"] == null ? String.Empty : reader["adress"].ToString(),
								Birthday = reader.IsDBNull(reader.GetOrdinal("birthday")) ? DateTime.MinValue : Convert.ToDateTime(reader["birhtday"]),
								Email = reader["email"] == null ? String.Empty : reader["email"].ToString(),
								Phone = reader["phone"] == null ? String.Empty : reader["phone"].ToString(),
								DateCount = Convert.ToInt32(reader["dateCount"].ToString()),
								HourCountPerDay = Convert.ToInt32(reader["hourCountPerDay"].ToString()),
								HolidaysPerYear = Convert.ToInt32(reader["holidaysPerYear"].ToString())
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
			string sql = "SELECT * FROM employees WHERE id = " + id;

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
								Adress = reader["adress"].ToString(),
								Birthday = reader["birthday"] == null ? DateTime.MinValue : DateTime.Parse(reader["birthday"].ToString()),
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

		//[WebMethod]
		//public void InsertEmployee(string em)
		//{
		//	EmployeeRow row = Serialize.FromBase64<EmployeeRow>(em);

		//	StringBuilder sb = new StringBuilder("INSERT INTO employees (firstName, lastName, adress, birthday, email, phone,dateCount, hourCountPerDay, holidaysPerYear) Values (");

		//	int fieldCount = 9;

		//	for (int i = 0; i < fieldCount; i++)
		//	{
		//		sb.Append(Connection.ParamMarker("var" + i));

		//		if (i + 1 < fieldCount)
		//			sb.Append(',');
		//	}

		//	using (DbCommand command = Connection.GetCommand(sb.ToString()))
		//	{
		//		Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = row.FirstName;
		//		Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = row.LastName;
		//		Connection.AddParam(command, Connection.ParamMarker("var2"), System.Data.DbType.String).Value = row.Adress;
		//		Connection.AddParam(command, Connection.ParamMarker("var3"), System.Data.DbType.DateTime).Value = row.Birthday;
		//		Connection.AddParam(command, Connection.ParamMarker("var4"), System.Data.DbType.String).Value = row.Email;
		//		Connection.AddParam(command, Connection.ParamMarker("var5"), System.Data.DbType.String).Value = row.Phone;
		//		Connection.AddParam(command, Connection.ParamMarker("var6"), System.Data.DbType.Int32).Value = row.DateCount;
		//		Connection.AddParam(command, Connection.ParamMarker("var7"), System.Data.DbType.Int32).Value = row.HourCountPerDay;
		//		Connection.AddParam(command, Connection.ParamMarker("var8"), System.Data.DbType.Int32).Value = row.HolidaysPerYear;

		//		command.ExecuteNonQuery();
		//	}
		//}

		[WebMethod]
		public int InsertEmployee(string firstName, string lastName)
		{
			Connection.BeginTransaction();
			try
			{
				StringBuilder sb = new StringBuilder("INSERT INTO employees (firstName, lastName) Values (");

				int fieldCount = 2;

				for (int i = 0; i < fieldCount; i++)
				{
					sb.Append(Connection.ParamMarker("var" + i));

					if (i + 1 < fieldCount)
						sb.Append(',');
				}
				sb.Append(')');

				using (DbCommand command = Connection.GetCommand(sb.ToString()))
				{
					Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = firstName;
					Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = lastName;
					command.ExecuteNonQuery();
				}
				using (var command = Connection.GetCommand("select id from employees as e where e.firstName = " + Connection.ParamMarker("var0") + " and e.lastName = " + Connection.ParamMarker("var1")))
				{

					Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = firstName;
					Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = lastName;
					var id = Convert.ToInt32(command.ExecuteScalar());
					Connection.Commit();
					return id;
				}
			}
			catch
			{
				Connection.Rollback();
				return 0;
			}
		}

		[WebMethod]
		public void UpdateEmployeeColumn(int id, string column, object value)
		{
			StringBuilder sb = new StringBuilder("UPDATE employees SET ");
			sb.Append(column);
			sb.Append(" = ");
			sb.Append(Connection.ParamMarker("var0"));
			sb.Append(" WHERE id = ");
			sb.Append(Connection.ParamMarker("idParam"));

			using (DbCommand command = Connection.GetCommand(sb.ToString()))
			{
				Connection.AddParam(command, Connection.ParamMarker("idParam"), System.Data.DbType.Int32).Value = id;
				Connection.AddParam(command, Connection.ParamMarker("var0"), Connection.Fields(false, "employees").FirstOrDefault(c => c.Name.ToUpper() == column.ToUpper()).DataTypeName == "date" ? System.Data.DbType.Date :
					Connection.DataTypeToDbType(Connection.Fields(false, "employees").FirstOrDefault(c => c.Name.ToUpper() == column.ToUpper()))).Value = value;

				command.ExecuteNonQuery();
				command.Parameters.Clear();
			}
		}

		[WebMethod]
		public void UpdateEmployee(string EmTable)
		{
			StringBuilder sb = new StringBuilder("UPDATE employees  SET ");
			sb.Append("firstName = ");
			sb.Append(Connection.ParamMarker("var0"));
			sb.Append(", ");
			sb.Append("lastName = ");
			sb.Append(Connection.ParamMarker("var1"));
			sb.Append(", ");
			sb.Append("adress = ");
			sb.Append(Connection.ParamMarker("var2"));
			sb.Append(", ");
			sb.Append("birthday = ");
			sb.Append(Connection.ParamMarker("var3"));
			sb.Append(", ");
			sb.Append("email = ");
			sb.Append(Connection.ParamMarker("var4"));
			sb.Append(", ");
			sb.Append("phone = ");
			sb.Append(Connection.ParamMarker("var5"));
			sb.Append(", ");
			sb.Append("dateCount = ");
			sb.Append(Connection.ParamMarker("var6"));
			sb.Append(", ");
			sb.Append("hourCountPerDay = ");
			sb.Append(Connection.ParamMarker("var7"));
			sb.Append(", ");
			sb.Append("holidaysPerYear = ");
			sb.Append(Connection.ParamMarker("var8"));
			sb.Append(" WHERE id = ");
			sb.Append(Connection.ParamMarker("idParam"));

			Connection.BeginTransaction();


			using (DbCommand command = Connection.GetCommand(sb.ToString()))
			{
				foreach (var row in Serialize.FromBase64<EmployeeTable>(EmTable).Rows)
				{
					Connection.AddParam(command, Connection.ParamMarker("idParam"), System.Data.DbType.Int32).Value = row.Id;
					Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.String).Value = row.FirstName;
					Connection.AddParam(command, Connection.ParamMarker("var1"), System.Data.DbType.String).Value = row.LastName;
					Connection.AddParam(command, Connection.ParamMarker("var2"), System.Data.DbType.String).Value = row.Adress;
					Connection.AddParam(command, Connection.ParamMarker("var3"), System.Data.DbType.DateTime).Value = row.Birthday;
					Connection.AddParam(command, Connection.ParamMarker("var4"), System.Data.DbType.String).Value = row.Email;
					Connection.AddParam(command, Connection.ParamMarker("var5"), System.Data.DbType.String).Value = row.Phone;
					Connection.AddParam(command, Connection.ParamMarker("var6"), System.Data.DbType.Int32).Value = row.DateCount;
					Connection.AddParam(command, Connection.ParamMarker("var7"), System.Data.DbType.Int32).Value = row.HourCountPerDay;
					Connection.AddParam(command, Connection.ParamMarker("var8"), System.Data.DbType.Int32).Value = row.HolidaysPerYear;

					command.ExecuteNonQuery();
					command.Parameters.Clear();
				}
			}
			Connection.Commit();
		}

		[WebMethod]
		public void DeleteEmployee(int id)
		{
			using (DbCommand command = Connection.GetCommand("DELETE FROM employee WHERE id = " + Connection.ParamMarker("var0")))
			{
				Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32).Value = id;
				command.ExecuteNonQuery();
			}
		}

		[WebMethod]
		public void DeleteEmployees(List<int> ids)
		{
			try
			{
				Connection.BeginTransaction();
				using (DbCommand command = Connection.GetCommand("DELETE FROM employees WHERE id = " + Connection.ParamMarker("var0")))
				{
					Connection.AddParam(command, Connection.ParamMarker("var0"), System.Data.DbType.Int32);
					foreach (var id in ids)
					{
						command.Parameters[0].Value = id;
						command.ExecuteNonQuery();
					}
				}

				Connection.Commit();
			}
			catch
			{
				Connection.Rollback();
			}
		}
	}
}
