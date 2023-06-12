using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace S2GroupProject.Forms
{
    public partial class AddShiftUC : UserControl
    {
        private readonly IEmployeeContainer _empContainer;
        Employee selectedEmployee;
        List<Employee> emp = new List<Employee>();
        DateTime shiftDate;
        FlowLayoutPanel layoutEmps;
        public AddShiftUC(IEmployeeContainer empContainer, List<Employee> emps, DateTime selectedDate)
        {
            InitializeComponent();
            _empContainer = empContainer;
             emp = emp;
             shiftDate = selectedDate;

            FlowLayoutPanel empsToChooseFrom = new FlowLayoutPanel();
            empsToChooseFrom.AutoSize = true;
            empsToChooseFrom.BackColor = Color.White;

            foreach (var emp in emps)
            {
                EmployeePorfileUC employeeControl = new EmployeePorfileUC(emp, empContainer);
                employeeControl.MouseDoubleClick += EmployeeControl_MouseDoubleClick; // Attach the MouseDoubleClick event handler

                empsToChooseFrom.Controls.Add(employeeControl);
            }

            this.Controls.Add(empsToChooseFrom);
            layoutEmps = empsToChooseFrom;
        }

        private void EmployeeControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Retrieve the employee object associated with the clicked EmployeePorfileUC control
             selectedEmployee = ((EmployeePorfileUC)sender).employee;

            // Perform any necessary operations with the selectedEmployee
            // ...
        }
        private void AddShiftBtn_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                int selectedMonth = shiftDate.Month;

                ShiftPreference shiftPreference = selectedEmployee.ShiftPreferences.FirstOrDefault(s => s.Month == selectedMonth);

                if (shiftPreference != null)
                {
                    ShiftTypes shiftType = shiftPreference.Preference;
                    Shift shiftToAdd = new Shift(shiftDate, shiftType, false );

                    selectedEmployee.ShiftsDates.Add(shiftToAdd);
                    OnShiftAdded(selectedEmployee);
                    _empContainer.AddEmpShift(selectedEmployee);
                }
                else
                {
                    Shift shiftToAdd = new Shift(shiftDate, ShiftTypes.MORNING, false);
                    selectedEmployee.ShiftsDates.Add(shiftToAdd);
                    OnShiftAdded(selectedEmployee);
                    _empContainer.AddEmpShift(selectedEmployee);
                }
            }
            else
            {
                MessageBox.Show("Please select an Employee");
            }
            
        }
        public event Action<Employee> ShiftAdded;

        private void OnShiftAdded(Employee selectedEmployee)
        {
            ShiftAdded?.Invoke(selectedEmployee);
        }
    }
}
