using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLib.DepartmentGroup
{
	public class DepartmentGroupTable
	{
		public DepartmentGroupTable()
		{
			Rows = new List<DepartmentGroupRow>();
		}

		public List<DepartmentGroupRow> Rows { get; private set; }
	}
}
