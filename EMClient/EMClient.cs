using acadGraph.Libs.RpcClientLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMLib;

namespace EMClient
{
	public partial class EMClient : Form
	{
		RpcClient employeeClient = new RpcClient(EMLib.Config.RpcConfigString, "Employee");
		RpcClient departmentClient = new RpcClient(Config.RpcConfigString, "Departments");
		public EMClient()
		{
			InitializeComponent();
		}

		void em_Refresh()
		{
			pgEmployee.Refresh();
		}

		private void tsbNewEmployee_Click(object sender, EventArgs e)
		{
			NewEmployee newEM = new NewEmployee();
			if(newEM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var item = lvEmployees.Items.Add(newEM.FirstName + " " + newEM.LastName);
				var em = new EMLib.Employees.EmployeeRow() { FirstName = newEM.FirstName, LastName = newEM.LastName };
				em.departments = new EMLib.CheckedListBox();
				var id = employeeClient.CallSyncMethod("InsertEmployee", newEM.FirstName, newEM.LastName);
				em.departments.EmployeeId = Convert.ToInt32(id);
				var departments = departmentClient.CallSyncMethod("GetDepartmentsByEmployeeId", em.Id);
				em.departments.Items = new Dictionary<string, bool>();
				item.Tag = em;
			}
		}

		private void LoadEmployees()
		{
			lvEmployees.Items.Clear();
			var result = Serialize.FromBase64<EMLib.Employees.EmployeeTable>(employeeClient.CallSyncMethod("GetEmployees").ToString());
			foreach (var employee in result.Rows)
			{
				var item = lvEmployees.Items.Add(employee.FirstName + " " + employee.LastName);
				employee.Refresh += em_Refresh;
				employee.departments = new EMLib.CheckedListBox();
				employee.departments.EmployeeId = employee.Id;
				//var departments = departmentClient.CallSyncMethod("GetDepartmentsByEmployeeId", employee.Id);
				//employee.departments.Items = (Dictionary<string, bool>)departments;
				employee.departments.Items = new Dictionary<string, bool>();
				item.Tag = employee;
			}
		}

		private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvEmployees.SelectedItems.Count > 0)
			{
				pgEmployee.SelectedObject = lvEmployees.SelectedItems[0].Tag;
				tsbDeleteEmployee.Enabled = true;
			}
			else
				tsbDeleteEmployee.Enabled = false;
		}

		private void pgEmployee_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			var em = (EMLib.Employees.EmployeeRow)lvEmployees.SelectedItems[0].Tag;
			employeeClient.CallSyncMethod("UpdateEmployeeColumn", em.Id, e.ChangedItem.PropertyDescriptor.Name.ToCharArray().First().ToString().ToLower() +
				e.ChangedItem.PropertyDescriptor.Name.Substring(1), e.ChangedItem.Value);
		}

		private void tsbDeleteEmployee_Click(object sender, EventArgs e)
		{
			if(lvEmployees.SelectedItems.Count > 0)
			{
				List<int> ids = new List<int>();

				foreach (ListViewItem item in lvEmployees.SelectedItems)
				{
					ids.Add(((EMLib.Employees.EmployeeRow)item.Tag).Id);
				}
				employeeClient.CallSyncMethod("DeleteEmployees", ids);
				Array array = Array.CreateInstance(typeof(ListViewItem), lvEmployees.SelectedItems.Count);
				lvEmployees.SelectedItems.CopyTo(array, 0);
				foreach (ListViewItem item in array)
				{
					lvEmployees.Items.Remove(item);
				}
			}
		}

		private void tsbLocations_Click(object sender, EventArgs e)
		{
			NewLocation nl = new NewLocation();
			nl.ShowDialog();
		}

		private void tsbDepartments_Click(object sender, EventArgs e)
		{
			NewDepartment newDep = new NewDepartment();

			newDep.ShowDialog();
		}

		private void tsbMapping_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Diese Funktion ist leider verbuggt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			new Locations().ShowDialog();
		}

		private void tsbLoad_Click(object sender, EventArgs e)
		{
			LoadEmployees();
		}
	}
}
