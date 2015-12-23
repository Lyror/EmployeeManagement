using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLib.Departments
{
	public class DepartmentTable
	{
		public DepartmentTable()
		{
			Rows = new List<DepartmentRow>();
		}

		public List<DepartmentRow> Rows { get; private set; }
	}
}
