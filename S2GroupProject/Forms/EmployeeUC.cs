using S2GroupProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2GroupProject
{
	public partial class EmployeeUC : UserControl
	{
		Employee emp;
		public EmployeeUC(Employee employee)
		{
			InitializeComponent();
			this.emp = employee;
			employeeName.AutoSize = true;
			employeeName.Text = emp.FirstName + " " + emp.LastName;
			bsn.Text = emp.BSN.ToString();
			telNumber.Text = emp.TelNumber.ToString();

			foreach (var shift in emp.ShiftsDates)
			{
				employeeShiftLb.Items.Add(shift);
			}

		}
		
	}
}
