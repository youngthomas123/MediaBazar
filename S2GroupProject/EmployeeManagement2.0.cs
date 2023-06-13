using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.DataAccess.Database;
using Microsoft.Extensions.DependencyInjection;
using S2GroupProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediaBazar.BusinessLogic.Classes.MyEnums;

namespace S2GroupProject
{
    public partial class EmployeeManagement2 : Form
    {
        private readonly IEmployeeContainer _employeeContainer;
        private readonly IItemContainer _itemContainer;
        private readonly IServiceProvider _serviceProvider;
        List<Employee> employees = new List<Employee>();
        public EmployeeManagement2(IItemContainer itemContainer, IEmployeeContainer employeeContainer, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _employeeContainer = employeeContainer;
            _itemContainer = itemContainer;
            RemoveEmployee.Appearance = TabAppearance.FlatButtons;
            RemoveEmployee.ItemSize = new Size(0, 1);
            LoadingData();
        }
        public void LoadingData()
        {
            employees = _employeeContainer.LoadEmployees();

            jobPositionsFilterCb.DataSource = Enum.GetValues(typeof(JobPositions));
            jobPositionsFilterCb.SelectedIndex = -1;

            foreach (var contract in Enum.GetValues(typeof(ContractTypes)))
            {

                contractTypeFilterClb.Items.Add(contract);
            }
            foreach (Control control in groupBox4.Controls)
            {
                if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.Text = "NONE";
                }
            }
        }

        private void EmpOverviewRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (EmpOverviewRBT.Checked == true)
            {
                LoadEmployeesIntoEmpOverview();
                EmployeeOverview.Show();
                ScheduleOverview.Hide();
                AddEmployee.Hide();
                RemoveEmployeeTab.Hide();
                WarehouseEmployees.Hide();
            }
        }
        public void LoadEmployeesIntoEmpOverview()
        {
            employees = _employeeContainer.LoadEmployees();
            foreach (var emp in employees)
            {
                if (IsEmployeeAdded(emp))
                {
                    continue;
                }
                empLayoutPanel.Controls.Add(new EmployeePorfileUC(emp, _employeeContainer));
            }
        }

        public List<EmployeePorfileUC> EmpProfiles()
        {
            employees = _employeeContainer.LoadEmployees();
            List<EmployeePorfileUC> empProfiles= new List<EmployeePorfileUC>();
            foreach (var emp in employees)
            {
                if (IsEmployeeAdded(emp))
                {
                    continue;
                }
                empLayoutPanel.Controls.Add(new EmployeePorfileUC(emp, _employeeContainer));
            }
            empProfiles.AddRange(empLayoutPanel.Controls.OfType<EmployeePorfileUC>());
            return empProfiles;
        }
        public bool IsEmployeeAdded(Employee emp)
        {
            foreach (Control control in empLayoutPanel.Controls)
            {
                if (control is EmployeePorfileUC profileUc)
                {

                    if (profileUc.employee.BSN == emp.BSN)
                        return true;
                }
            }
            return false;
        }

        private void jobPositionsFilterCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            JobPositions jobPosition = (JobPositions)jobPositionsFilterCb.SelectedIndex;
            List<EmployeePorfileUC> filteredControls = new List<EmployeePorfileUC>();

            if (jobPosition == JobPositions.NONE)
            {
                LoadEmployeesIntoEmpOverview();
                return;
            }
            else
            {
                foreach (EmployeePorfileUC emp in EmpProfiles())
                {
                    if (emp.employee.Jobposition == jobPosition)
                    {
                        filteredControls.Add(emp);
                    }
                }
            }

            empLayoutPanel.Controls.Clear();
            empLayoutPanel.Controls.AddRange(filteredControls.ToArray());
        }

        private void shiftDayPickerFilter_ValueChanged(object sender, EventArgs e)
        {
            DateTime shift = shiftDayPickerFilter.Value.Date;
            List<EmployeePorfileUC> filteredControls = new List<EmployeePorfileUC>();

            List<EmployeePorfileUC> empProfiles = EmpProfiles();

            foreach (EmployeePorfileUC emp in empProfiles)
            {
                if (emp.employee.ShiftsDates.Any(s => s.ShiftDate.Date == shift))
                {
                    filteredControls.Add(emp);
                }
            }

            empLayoutPanel.Controls.Clear();
            empLayoutPanel.Controls.AddRange(filteredControls.ToArray());
        }

        private void contractTypeFilterClb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<ContractTypes> checkedItems = new List<ContractTypes>();

            // Get the list of currently checked items
            foreach (var item in contractTypeFilterClb.CheckedItems)
            {
                checkedItems.Add((ContractTypes)item);
            }

            // If the event is fired after the item state has changed
            if (e.NewValue == CheckState.Checked)
            {
                checkedItems.Add((ContractTypes)contractTypeFilterClb.Items[e.Index]);
            }
            else
            {
                checkedItems.Remove((ContractTypes)contractTypeFilterClb.Items[e.Index]);
            }

            List<EmployeePorfileUC> filteredControls = new List<EmployeePorfileUC>();
            List<EmployeePorfileUC> empProfiles = EmpProfiles();

            foreach (EmployeePorfileUC emp in empProfiles)
            {
                if (checkedItems.Contains(emp.employee.ContractType) || checkedItems.Contains(ContractTypes.NONE))
                {
                    filteredControls.Add(emp);
                }
            }

            empLayoutPanel.Controls.Clear();
            empLayoutPanel.Controls.AddRange(filteredControls.ToArray());
        }
        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        private void SheduleOverviewRbt_CheckedChanged(object sender, EventArgs e)
        {
            if (SheduleOverviewRbt.Checked == true)
            {
                DisplayCalendar();
                ScheduleShiftsMonthCbb.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames;

                ScheduleOverview.Show();
                EmployeeOverview.Hide();
                AddEmployee.Hide();
                RemoveEmployeeTab.Hide();
                WarehouseEmployees.Hide();
            }
        }
        private void DisplayCalendar()
        {
            flowLayoutPanel1.Controls.Clear();

            monthLb.Text = currentYear + " " + DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);

            DateTime startOfTheMonth = new DateTime(currentYear, currentMonth, 1);
            int daysInMoth = DateTime.DaysInMonth(currentYear, currentMonth);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayOfTheWeek + 1; i++)
            {
                CalendarDay emptyDay = new CalendarDay();
                flowLayoutPanel1.Controls.Add(emptyDay);
            }

            for (int i = 1; i <= daysInMoth; i++)
            {
                Days dayOfMonth = _serviceProvider.GetService<Days>();
                dayOfMonth.DaysForCal(i);
                dayOfMonth.Date = new DateTime(currentYear, currentMonth, i);
                flowLayoutPanel1.Controls.Add(dayOfMonth);
            }

            for (int i = 0; i < (42 - flowLayoutPanel1.Controls.Count); i++)
            {
                CalendarDay ucDat = new CalendarDay();
                flowLayoutPanel1.Controls.Add(ucDat);

            }
        }



        private void prevBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (!checkBox1.Checked) 
            { 
                if (currentMonth == 1)
                {
                currentMonth = 13;
                currentYear--;
                }
            currentMonth--;
            DisplayCalendar();
            }
            else
            {
                now = now.AddDays(-7);
                startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek).AddDays(1);
                endOfWeek = startOfWeek.AddDays(6);
                RefreshCalendar();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (!checkBox1.Checked)
            {
                if (currentMonth == 12)
                {
                    currentMonth = 0;
                    currentYear++;
                }
                currentMonth++;
                DisplayCalendar();
            }
            else
            {
                now = now.AddDays(7);
                startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek).AddDays(1);
                endOfWeek = startOfWeek.AddDays(6);
                RefreshCalendar();
            }
        }
        static DateTime now = DateTime.Now;
        static DateTime startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek);
        DateTime endOfWeek = startOfWeek.AddDays(6);
        private void displayWeeklyDays()
        {
            DateTime now = DateTime.Now;
            monthLb.Text = now.ToString("yyyy") + " " + now.ToString("MMM");

            // Calculate the start and end dates of the current week
            DateTime startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek).AddDays(1);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            for (DateTime date = startOfWeek; date <= endOfWeek; date = date.AddDays(1))
            {
                // Create a Days control for each day of the week
                Days calendarDays = _serviceProvider.GetService<Days>();
                calendarDays.DaysForCal(date.Day);
                calendarDays.Date = date; // Set the date property of the control
                flowLayoutPanel1.Controls.Add(calendarDays);
            }
        }

        void RefreshCalendar()
        {
            // Clear the calendar display
            flowLayoutPanel1.Controls.Clear();
            monthLb.Text = now.ToString("MMMM");

            // Display the days of the week
            for (DateTime date = startOfWeek; date <= endOfWeek; date = date.AddDays(1))
            {
                Days calendarDays = _serviceProvider.GetService<Days>();
                calendarDays.DaysForCal(date.Day);
                calendarDays.Date = date;
                flowLayoutPanel1.Controls.Add(calendarDays);
            }
        }



        private void monthLb_Click(object sender, EventArgs e)
        {

        }

        private void ScheduleOverview_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                flowLayoutPanel1.Controls.Clear();
                displayWeeklyDays();

                foreach (var control in ScheduleOverview.Controls)
                {
                    if (control is Label label && label.Name != "monthLb")
                    {
                        label.Hide();
                    }
                }
               // displayWeeklyDays();
            }
            else
            {
                DisplayCalendar();
            }
        }

        public void AssignShifts(int year, int month)
        {
            // Get all full-time employees
            employees = _employeeContainer.LoadEmployees();
            List<Employee> fullTimeEmployees = employees.Where(e => e.ContractType == ContractTypes.FULL_TIME || e.ContractType == ContractTypes.PART_TIME).ToList();

            // Generate all possible shifts for the specified month
            DateTime currentDate = new DateTime(year, month, 1);
            DateTime endDate = currentDate.AddMonths(1).AddDays(-1);
            List<Shift> allShifts = new List<Shift>();
            while (currentDate <= endDate)
            {
                foreach (Employee employee in fullTimeEmployees)
                {
                    ShiftPreference preference = employee.ShiftPreferences.FirstOrDefault(s => s.Month == month);
                    bool alreadyAssigned = employee.ShiftsDates.Any(shift => shift.ShiftDate == currentDate);
                    //false if emp has scheduled a sick leave xd
                    bool isEmpSick = employee.SickLeaves == null || employee.SickLeaves.Count == 0 ||
                                     !employee.SickLeaves.Any(sickLeave => sickLeave.StartDate <= currentDate && currentDate <= sickLeave.EndDate && sickLeave.IsScheduled);

                    if (preference != null && !alreadyAssigned && !employee.DaysOff.Contains(currentDate.DayOfWeek) && isEmpSick)
                    {
                        Shift newShift = new Shift(currentDate, preference.Preference, false);
                        employee.ShiftsDates.Add(newShift);
                        _employeeContainer.AddEmpShift(employee);
                    }
                }
                currentDate = currentDate.AddDays(1);
            }
        }
        private void ScheduleMonthlyShifts_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            string selectedMonth = ScheduleShiftsMonthCbb.SelectedItem.ToString();
            int monthNumber;
            if (DateTime.TryParseExact(selectedMonth, "MMMM", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime result))
            {
                monthNumber = result.Month;
            }
            else
            {
                // Handle invalid selection
                monthNumber = -1;
            }
            AssignShifts(currentYear, monthNumber);
            
        }

        private void DeleteItemsRBT_CheckedChanged(object sender, EventArgs e)
        {

        }
        private int workingHoursPerWeek;
        private void ShowEmployees_Click(object sender, EventArgs e)
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

            if (hoursPerWeekTb.Visible == true)
            {
                if (!int.TryParse(hoursPerWeekTb.Text, out workingHoursPerWeek))
                {
                    MessageBox.Show("Invalid working hours per week. Please enter a valid integer.");
                    return;
                }
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

        private void AddEmployeeRBT_CheckedChanged(object sender, EventArgs e)
        {

            AddEmployee.Show();
            LoadData();
            EmployeeOverview.Hide();
            ScheduleOverview.Hide();
            RemoveEmployeeTab.Hide();
            WarehouseEmployees.Hide();
        }

        private void DeleteEmployeeRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteEmployeeRBT.Checked == true)
            {
                LoadEmployeesIntoDeleteEmployeePanel();
                RemoveEmployeeTab.Show();
                LoadData();
                EmployeeOverview.Hide();
                ScheduleOverview.Hide();
                AddEmployee.Hide();
                WarehouseEmployees.Hide();
            }

        }
        public void LoadEmployeesIntoDeleteEmployeePanel()
        {
            deleteEmpLayoutPanel.Controls.Clear();
            employees = _employeeContainer.LoadEmployees();
            foreach (var emp in employees)
            {
                if (IsEmployeeAddedToDeleteLayout(emp))
                {
                    continue;
                }
                EmployeePorfileUC employeeControl = new EmployeePorfileUC(emp, _employeeContainer);
                employeeControl.MouseDoubleClick += EmployeeControl_MouseDoubleClick;
                deleteEmpLayoutPanel.Controls.Add(employeeControl);
            }
        }
        public bool IsEmployeeAddedToDeleteLayout(Employee emp)
        {
            foreach (Control control in deleteEmpLayoutPanel.Controls)
            {
                if (control is EmployeePorfileUC profileUc)
                {

                    if (profileUc.employee.BSN == emp.BSN)
                        return true;
                }
            }
            return false;
        }
        Employee selectedEmployee;
        private void button2_Click(object sender, EventArgs e)
        {
            _employeeContainer.DeleateEmployee(selectedEmployee.BSN);
            LoadEmployeesIntoDeleteEmployeePanel();
        }
        private void EmployeeControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            selectedEmployee = ((EmployeePorfileUC)sender).employee;

        }
    }
}

