using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.DataAccess.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2GroupProject.Forms
{
    public partial class EmployeePorfileUC : UserControl
    {
        private readonly IEmployeeContainer _employeeContainer;
        public Employee employee;
        public event Action<Employee, bool> DoubleClickEvent;
        public EmployeePorfileUC(Employee emp, IEmployeeContainer employeeContainer)
        {
            InitializeComponent();
            _employeeContainer = employeeContainer;
            employee = emp;
            label1.Text = employee.FirstName + " " + employee.LastName;
            label2.Text = employee.Jobposition.ToString();

            label1.AutoSize = false;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int label1Width = TextRenderer.MeasureText(label1.Text, label1.Font).Width;
            label1.Width = label1Width;
            label1.Left = (this.Width - label1.Width) / 2;

            label2.AutoSize = false;
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int label2Width = TextRenderer.MeasureText(label2.Text, label2.Font).Width;
            label2.Width = label2Width;
            label2.Left = (this.Width - label2.Width) / 2;
        }
        public EmployeePorfileUC()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = employee;

            //if (employeesLb.SelectedItem != null)
            // {
            var popupForm = new Form();



            // Create an instance of your user control
            var myUserControl = new EmployeeUC(emp, _employeeContainer);


            popupForm.ClientSize = new Size(myUserControl.Width, myUserControl.Height);
            myUserControl.Dock = DockStyle.Fill;

            // Set any properties or values on your user control here
            // ...

            // Add your user control to the form's Controls collection
            popupForm.Controls.Add(myUserControl);

            // Set the properties of the form to make it look like a popup
            //popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            popupForm.StartPosition = FormStartPosition.CenterParent;

            // Display the form as a modal dialog
            popupForm.ShowDialog();
            //MessageBox.Show(employees[index].ShiftsDates.Select(s => s.ToString())) ;
            //}
        }
        //private EmployeePorfileUC selectedEmployeeControl = null;
        //private void EmployeePorfileUC_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (selectedEmployeeControl != null)
        //    {
        //        selectedEmployeeControl.BackColor = Color.LightBlue; // Set the desired deselected color
        //        selectedEmployeeControl = null;
        //    }

        //    BackColor = Color.DarkRed;
        //    EmployeeProileUCDoubleClick(sender);

        //}

        //private Employee EmployeeProileUCDoubleClick(object sender)
        //{
        //    return employee;
        //}

        private bool isSelected = false;

        private void EmployeePorfileUC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isSelected)
            {
                BackColor = Color.LightBlue; // Set the desired deselected color
                isSelected = false;
            }
            else
            {
                BackColor = Color.DarkRed; // Set the desired selected color
                isSelected = true;
            }

            // Retrieve the employee associated with this user control
            Employee selectedEmployee = employee;
            // Raise the event to notify the double click on the control
            DoubleClickEvent?.Invoke(selectedEmployee, isSelected);
        }

    }   
}
