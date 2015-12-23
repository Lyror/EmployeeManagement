using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLib.Employees
{
	[Serializable]
	public class EmployeeRow
	{
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public String Address { get; set; }
		public DateTime Birthday { get; set; }
		public String Email { get; set; }
		public String Phone { get; set; }
		public int DateCount { get; set; }
		public int HourCountPerDay { get; set; }
		public int HolidaysPerYear{ get; set; }
		public int HourCountPerWeek { get { return DateCount * HourCountPerDay; } }
	}
}
