

using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using S2GroupProject.Forms;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using static MediaBazar.BusinessLogic.Classes.MyEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace S2GroupProject
{
	public partial class MainPage : Form
	{
		//The containers
		private readonly IEmployeeContainer _employeeContainer;
		private readonly IItemContainer _itemContainer;
		private readonly IServiceProvider _serviceProvider;


		List<Employee> employees = new List<Employee>();

		//DataBaseManager database = new DataBaseManager();

		public MainPage(IItemContainer itemContainer, IEmployeeContainer employeeContainer, IServiceProvider serviceProvider)
		{
			_employeeContainer = employeeContainer;
			_itemContainer = itemContainer;
			_serviceProvider = serviceProvider;
			InitializeComponent();
			LoadingData();

		}

		static DateTime now = DateTime.Now;
		static DateTime startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek);
		DateTime endOfWeek = startOfWeek.AddDays(6);

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = employeesLb.SelectedIndex;

			if (employeesLb.SelectedItem != null)
			{
				var popupForm = new Form();



				// Create an instance of your user control
				var myUserControl = new EmployeeUC(employees[index], _employeeContainer);


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
			}
		}

        public void LoadingData()
        {
           // contractCb.Items.Clear();
           // daysOffClb.Items.Clear();
           // jobPositionCb.Items.Clear();
            employeesLb.Items.Clear();
            //shiftTypeCb.Items.Clear();
            contractTypeFilterClb.Items.Clear();
           // jobPositionsFilterCb.Items.Clear();
            employees = _employeeContainer.LoadEmployees();


            foreach (var employee in employees)
            {

                employeesLb.Items.Add(employee);
            }

            shiftTypeCb.DataSource = Enum.GetValues(typeof(ShiftTypes));

			foreach (var contract in Enum.GetValues(typeof(ContractTypes)))
            {

                contractTypeFilterClb.Items.Add(contract);
            }
            
			jobPositionsFilterCb.DataSource = Enum.GetValues(typeof(JobPositions));
			jobPositionsFilterCb.SelectedIndex = -1;

			foreach (Control control in groupBox4.Controls)
			{
				if (control is System.Windows.Forms.ComboBox comboBox)
				{
					comboBox.Text = "NONE";
				}
			}

			ScheduleShiftsMonthCbb.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames;


        }

		public void RefreshData()
		{
			LoadingData();

		}

		private void AddEmployee_Click(object sender, EventArgs e)
		{
			//string firstName = firstNameTb.Text;
			//string lastName = lastNameTb.Text;
			//int bsn = int.Parse(bsnTb.Text);
			//int telNubmer = int.Parse(telNumberTb.Text);
			//string address = addressTb.Text;
			//ContractTypes contractType = (ContractTypes)contractCb.SelectedItem;
			//int workingHoursPerWeek = int.Parse(hoursPerWeekTb.Text);
			//JobPositions jobPosition = (JobPositions)jobPositionCb.SelectedItem;
			//double wage = double.Parse(wageTb.Text);
			//int age = int.Parse(ageTb.Text);
			//List<DayOfWeek> daysOff = new List<DayOfWeek>();
			//foreach (var checkedItem in daysOffClb.CheckedItems)
			//{
			//    DayOfWeek day;
			//    if (Enum.TryParse(checkedItem.ToString(), out day))
			//    {
			//        daysOff.Add(day);
			//    }

			//}

			//_employeeContainer.AddEmployee(firstName, lastName, bsn, telNubmer, address, contractType, workingHoursPerWeek, jobPosition, wage, daysOff, age, new List<Shift>());

			//RefreshData();
		}




		private void RemoveBtn_Click(object sender, EventArgs e)
		{
			int bsn = int.Parse(bsnRemoveTb.Text);
			Employee empToRemove = _employeeContainer.GetEmployeeByBcn(bsn);
			bool isBscnAssigned = employees.Any(e => e.BSN == bsn);

			if (!isBscnAssigned)
			{
				MessageBox.Show($"Can't remove employee due to non-existing BSN");
			}
			else
			{


				employees.Remove(empToRemove);
				_employeeContainer.DeleateEmployee(bsn);
			}

			RefreshData();
		}

		private void ShowEmployees_Click(object sender, EventArgs e)
		{
			employeesLb.Items.Clear();
			foreach (Employee emp in employees)
			{
				employeesLb.Items.Add(emp);
			}
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			try
			{
				int bsn = Convert.ToInt32(searchTB.Text);
				Employee searchedEmployee = _employeeContainer.GetEmployeeByBcn(bsn);
				if (searchedEmployee != null)
				{
					employeesLb.Items.Clear();
					employeesLb.Items.Add(searchedEmployee);
				}
			}
			catch (Exception ex) { MessageBox.Show("Please select a bsn"); }
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			displayWeeklyDays();
		}
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

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			now = now.AddDays(-7);
			startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek).AddDays(1);
			endOfWeek = startOfWeek.AddDays(6);
			RefreshCalendar();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			now = now.AddDays(7);
			startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek).AddDays(1);
			endOfWeek = startOfWeek.AddDays(6);
			RefreshCalendar();
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

		private void createScheduleBtn_Click(object sender, EventArgs e)
		{
			Form formBackground = new Form();
			try
			{
				using (CalendarPopUp createTask = _serviceProvider.GetService<CalendarPopUp>())
				{
					formBackground.StartPosition = FormStartPosition.CenterScreen;
					formBackground.FormBorderStyle = FormBorderStyle.None;
					//formBackground.Opacity = .70d;
					//formBackground.BackColor = Color.Black;
					//formBackground.WindowState = FormWindowState.Maximized;
					formBackground.TopMost = true;
					formBackground.Location = this.Location;
					formBackground.ShowInTaskbar = false;
					formBackground.Show();

					createTask.Owner = formBackground;
					createTask.ShowDialog();

					formBackground.Dispose();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			finally
			{
				formBackground.Dispose();
			}
		}

		private void addShiftBtn_Click(object sender, EventArgs e)
		{


			_employeeContainer.AddShift(shiftDayPicker.Value.Date, int.Parse(shiftBsnTb.Text), (ShiftTypes)shiftTypeCb.SelectedItem);
			//manager.AddEmpShift(Global.myManagement.GetEmployeeByBcn(int.Parse(shiftBsnTb.Text)));
			RefreshData();
		}

        private void jobPositionsFilterCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            JobPositions jobPostion = (JobPositions)jobPositionsFilterCb.SelectedIndex;
            employeesLb.Items.Clear();

			if (jobPostion == JobPositions.NONE)
			{
				foreach (var item in employees)
				{
					employeesLb.Items.Add(item);
				}
			}
			else
			{
				foreach (var emp in employees)
				{

					if (emp.Jobposition == jobPostion)
					{
						employeesLb.Items.Add(emp);
					}

				}
			}
		}

		private void shiftDayPickerFilter_ValueChanged(object sender, EventArgs e)
		{
			DateTime shift = shiftDayPickerFilter.Value;
			employeesLb.Items.Clear();

			foreach (var emp in employees)
			{
				if (emp.ShiftsDates.Any(s => s.ShiftDate.Day == shift.Day))
				{
					employeesLb.Items.Add(emp);
				}
			}
		}

		private void contractTypeFilterClb_SelectedIndexChanged(object sender, EventArgs e)
		{
			employeesLb.Items.Clear();
			foreach (var emp in employees)
			{
				foreach (var checkedItem in contractTypeFilterClb.CheckedItems)
				{

					if (emp.ContractType == (ContractTypes)checkedItem)
					{
						employeesLb.Items.Add(emp);
					}

				}
			}

		}

		private void employeesLb_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox1_SelectedIndexChanged(sender, e);


		}


		private void SeeItemsButton_Click(object sender, EventArgs e)
		{
			//Form formBackground = new Form();
			//try
			//{
			//    using (ItemsPopUp createTask = new ItemsPopUp())
			//    {
			//        formBackground.StartPosition = FormStartPosition.CenterScreen;
			//        formBackground.FormBorderStyle = FormBorderStyle.None;
			//        formBackground.TopMost = true;
			//        formBackground.Location = this.Location;
			//        formBackground.ShowInTaskbar = false;
			//       // formBackground.Show();

			//Form formBackground = new Form();
			//try
			//{
			//    using (ItemsPopUp createTask = _serviceProvider.GetService<ItemsPopUp>())
			//    {
			//        formBackground.StartPosition = FormStartPosition.CenterScreen;
			//        formBackground.FormBorderStyle = FormBorderStyle.None;
			//        formBackground.TopMost = true;
			//        formBackground.Location = this.Location;
			//        formBackground.ShowInTaskbar = false;
			//        // formBackground.Show();
			////        createTask.Owner = formBackground;
			////        createTask.ShowDialog();

			////        formBackground.Dispose();
			////    }
			////}
			////catch (Exception ex)
			////{

			////    MessageBox.Show(ex.Message);
			////}
			////finally
			////{
			////    formBackground.Dispose();
			////}

		}

		private void AddAnEmpBtn_Click(object sender, EventArgs e)
		{
			Form formBackground = new Form();
			try
			{
				using (EmployeeManagementPopUp createTask = new EmployeeManagementPopUp(_employeeContainer))
				{
					formBackground.StartPosition = FormStartPosition.CenterScreen;
					formBackground.FormBorderStyle = FormBorderStyle.None;
					formBackground.TopMost = true;
					formBackground.Location = this.Location;
					formBackground.ShowInTaskbar = false;
					// formBackground.Show();

					createTask.Owner = formBackground;
					createTask.ShowDialog();

					formBackground.Dispose();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			finally
			{
				formBackground.Dispose();
				RefreshData();
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
									 !employee.SickLeaves.Any(sickLeave => sickLeave.StartDate <= currentDate && currentDate <= sickLeave.EndDate);

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
            RefreshData();
        }
    }
}



