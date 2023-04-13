
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
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

        private readonly IEmployeeContainer _employeeContainer;
        public EmployeeUC(Employee employee, IEmployeeContainer employeeContainer)
		{
			InitializeComponent();
			_employeeContainer = employeeContainer;
			this.emp = employee;
			employeeName.AutoSize = true;
			employeeName.Text = emp.FirstName + " " + emp.LastName;
			bsn.Text = emp.BSN.ToString();
			telNumber.Text = emp.TelNumber.ToString();

			foreach (var shift in emp.ShiftsDates)
			{
				employeeShiftLb.Items.Add(shift);
			}

			foreach(var sickLeave in emp.SickLeaves)
			{
				sickLeavesLb.Items.Add(sickLeave);

			}
		}
        private void ApproveSickLeave_Click(object sender, EventArgs e)
        {
			
            var sickLeave = (SickLeave)sickLeavesLb.SelectedItem;
            sickLeave.IsScheduled = true;
            _employeeContainer.UpdateEmpSickLeaveApproval(emp, sickLeave);
            RefreshSickLeave();
        }
        public void RefreshSickLeave()
		{
			sickLeavesLb.Items.Clear();
            foreach (var sickLeave in emp.SickLeaves)
            {
                sickLeavesLb.Items.Add(sickLeave);

            }
        }
		
    }
}
