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
            string lastName = lastNameTb.Text;
            int bsn = int.Parse(bsnTb.Text);
            string telNubmer = telNumberTb.Text;
            string address = addressTb.Text;
            ContractTypes contractType = (ContractTypes)contractCb.SelectedItem;
			int workingHours = workingHoursPerWeek;
			JobPositions jobPosition = (JobPositions)jobPositionCb.SelectedItem;
            double wage = double.Parse(wageTb.Text);
            int age = int.Parse(ageTb.Text);
            List<DayOfWeek> daysOff = new List<DayOfWeek>();

            foreach (var checkedItem in daysOffClb.CheckedItems)
            {
                DayOfWeek day;
                if (Enum.TryParse(checkedItem.ToString(), out day))
                {
                    daysOff.Add(day);
                }

            }

            _employeeContainer.AddEmployee(firstName, lastName, bsn, telNubmer, address, contractType, workingHoursPerWeek, jobPosition, wage, daysOff, age, new List<Shift>(), new List<SickLeave>());
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
