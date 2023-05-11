using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.DataAccess.Database;
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
    public partial class EmployeeManagementPopUp : Form
    {
        private readonly IEmployeeContainer _employeeContainer;
        public EmployeeManagementPopUp(IEmployeeContainer _employeeContainer)
        {
            this._employeeContainer = _employeeContainer;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            contractCb.Items.Clear();
            daysOffClb.Items.Clear();
            jobPositionCb.Items.Clear();
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                daysOffClb.Items.Add(day.ToString());
            }
            foreach (var jobPosition in Enum.GetValues(typeof(JobPositions)))
            {

                jobPositionCb.Items.Add(jobPosition);
            }

            foreach (var contract in Enum.GetValues(typeof(ContractTypes)))
            {

                contractCb.Items.Add(contract);
            }


        }

		private int workingHoursPerWeek;
		private void AddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTb.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name cannot be empty.");
                return;
            }

            string lastName = lastNameTb.Text;
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last name cannot be empty.");
                return;
            }

            int bsn;
            if (!int.TryParse(bsnTb.Text, out bsn))
            {
                MessageBox.Show("Invalid BSN. Please enter a valid integer.");
                return;
            }

            string telNumber = telNumberTb.Text;
            if (string.IsNullOrEmpty(telNumber))
            {
                MessageBox.Show("Telephone number cannot be empty.");
                return;
            }

            string address = addressTb.Text;
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address cannot be empty.");
                return;
            }

            ContractTypes contractType = (ContractTypes)contractCb.SelectedItem;
            if (contractType == null)
            {
                MessageBox.Show("Please select a contract type.");
                return;
            }

            int workingHours;
            if (!int.TryParse(hoursPerWeekTb.Text, out workingHours))
            {
                MessageBox.Show("Invalid working hours per week. Please enter a valid integer.");
                return;
            }

            JobPositions jobPosition = (JobPositions)jobPositionCb.SelectedItem;
            if (jobPosition == null)
            {
                MessageBox.Show("Please select a job position.");
                return;
            }

            double wage;
            if (!double.TryParse(wageTb.Text, out wage))
            {
                MessageBox.Show("Invalid wage. Please enter a valid decimal number.");
                return;
            }

            int age;
            if (!int.TryParse(ageTb.Text, out age))
            {
                MessageBox.Show("Invalid age. Please enter a valid integer.");
                return;
            }

            List<DayOfWeek> daysOff = new List<DayOfWeek>();
            foreach (var checkedItem in daysOffClb.CheckedItems)
            {
                DayOfWeek day;
                if (Enum.TryParse(checkedItem.ToString(), out day))
                {
                    daysOff.Add(day);
                }
            }

            _employeeContainer.AddEmployee(firstName, lastName, bsn, telNumber, address, contractType, workingHoursPerWeek, jobPosition, wage, daysOff, age, new List<Shift>(), new List<SickLeave>(), new List<ShiftPreference>());
            this.Close();
        }

		private void contractCb_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Update the workingHoursPerWeek variable based on the selected contract type
			ContractTypes contractType = (ContractTypes)contractCb.SelectedItem;
			if (contractType == MyEnums.ContractTypes.FULL_TIME)
			{
				workingHoursPerWeek = 40;
				hoursPerWeekTb.Visible = false;
				label7.Visible = false;
			}
			else
			{
				// Prompt the user to enter the working hours per week for other contract types
				// and store it in the workingHoursPerWeek variable
				if (int.TryParse(hoursPerWeekTb.Text, out int hours))
				{
					workingHoursPerWeek = hours;
				}
				else
				{
					// Handle the case where the entered value is not a valid integer
					// You can show an error message or set a default value, for example.
					// In this example, I'm setting it to 0.
					workingHoursPerWeek = 0;
				}
				hoursPerWeekTb.Visible = true;
				label7.Visible = true;
			}
		}
	}
}
