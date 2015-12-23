using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLib.Employees
{
	[Serializable]
	public class EmployeeTable
	{
		public EmployeeTable()
		{
			Rows = new List<EmployeeRow>();
		}

		public List<EmployeeRow> Rows { get; private set; }
	}
}
