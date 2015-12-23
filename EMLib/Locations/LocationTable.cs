using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLib.Locations
{
	public class LocationTable
	{
		public LocationTable()
		{
			Rows = new List<LocationRow>();
		}

		public List<LocationRow> Rows { get; private set; }
	}
}
