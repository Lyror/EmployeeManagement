using acadGraph.Libs.RpcClientLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMLib.Employees
{
	[TypeConverter(typeof(PropertySorter))]
	[Serializable]
	public class EmployeeRow
	{
		//RpcClient DepartmentClient = new RpcClient(Config.RpcConfigString, "Departments");

		public void LoadDepartments()
		{
			departments = new CheckedListBox();
		}

		int hourPerDay, dateCount;

		[Browsable(false)]
		public int Id { get; set; }

		[Category("Mitarbeiter")]
		[DisplayName("Vorname"), PropertyOrder(1)]
		[Description("Vorname des Mitarbeiters")]
		public String FirstName { get; set; }

		[Category("Mitarbeiter")]
		[DisplayName("Nachname"), PropertyOrder(2)]
		[Description("Nachname des Mitarbeiters")]
		public String LastName { get; set; }

		[Category("Mitarbeiter")]
		[DisplayName("Adresse"), PropertyOrder(3)]
		[Description("Adresse des Mitarbeiters")]
		public String Adress { get; set; }

		[Category("Mitarbeiter")]
		[DisplayName("Geburtsdatum"), PropertyOrder(4)]
		[Description("Geburtsdatum des Mitarbeiters")]
		public DateTime Birthday { get; set; }

		[Category("Mitarbeiter")]
		[Description("E-Mail des Mitarbeiters"), PropertyOrder(5)]
		[DisplayName("E-Mail")]
		public String Email { get; set; }

		[Category("Mitarbeiter")]
		[DisplayName("Telefonnummer"), PropertyOrder(6)]
		[Description("Telefonnummer des Mitarbeiters")]
		public String Phone { get; set; }

		[Category("Mitarbeiter")]
		[DisplayName("Anzahl der Arbeitstage"), PropertyOrder(7)]
		[Description("Anzahl der Arbeitstage des Mitarbeiters")]
		public int DateCount
		{
			get { return dateCount; }
			set
			{
				dateCount = value;
				if (Refresh != null)
					Refresh();
			}
		}

		[Category("Mitarbeiter")]
		[DisplayName("Anzahl der Arbeitsstunden pro Tag"), PropertyOrder(8)]
		[Description("Anzahl der Arbeitsstunden pro Tag des Mitarbeiters")]
		public int HourCountPerDay
		{
			get { return hourPerDay; }
			set
			{
				hourPerDay = value;
				if (Refresh != null)
					Refresh();
			}
		}

		[Category("Mitarbeiter")]
		[DisplayName("Anzahl der Arbeitstage pro Woche"), PropertyOrder(9)]
		[Description("Wird automatisch berechnet")]
		public int HourCountPerWeek { get { return DateCount * HourCountPerDay; } }

		[Category("Mitarbeiter")]
		[DisplayName("Urlaubstage"), PropertyOrder(10)]
		[Description("Urlaubstage des Mitarbeiters")]
		public int HolidaysPerYear { get; set; }

		[Category("Standorte")]
		[DisplayName("Abteilungen"), PropertyOrder(10)]
		[Description("Abteilungen des Mitarbeiters")]
		public CheckedListBox departments { get; set; }

		public event Action Refresh;


	}
}
