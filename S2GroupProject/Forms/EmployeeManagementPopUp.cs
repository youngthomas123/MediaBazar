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

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTb.Text;
            string lastName = lastNameTb.Text;
            int bsn = int.Parse(bsnTb.Text);
            int telNubmer = int.Parse(telNumberTb.Text);
            string address = addressTb.Text;
            ContractTypes contractType = (ContractTypes)contractCb.SelectedItem;
            int workingHoursPerWeek = int.Parse(hoursPerWeekTb.Text);
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

            _employeeContainer.AddEmployee(firstName, lastName, bsn, telNubmer, address, contractType, workingHoursPerWeek, jobPosition, wage, daysOff, age, new List<Shift>());
        }
    }
}
