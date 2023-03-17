using MediaBazarLib.Classes;
using S2GroupProject.Classes;
using S2GroupProject.Forms;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static S2GroupProject.Classes.MyEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace S2GroupProject
{
    public partial class MainPage : Form
    {


        List<Employee> employees = Global.myManagement.GetEmployees();

        public MainPage()
        {
            List<DayOfWeek> DayOfWeeks = new List<DayOfWeek>();
            DayOfWeeks.Add(DayOfWeek.Monday);
            DayOfWeeks.Add(DayOfWeek.Tuesday);

            //daysOffClb = new CheckedListBox();


            InitializeComponent();

           


            Global.myManagement.AddEmployee("Mihail", "Mihov", 1, +359123123, "Nqkudesi",
                                            ContractTypes.FULL_TIME, 16, JobPositions.STORE_MANAGER, 25,
                                            new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Saturday }, 19, null, null, new List<Shift>());
            Global.myManagement.AddEmployee("Panayot", "Panov", 2, +359123123, "Nqkudesi",
                                    ContractTypes.PART_TIME, 16, JobPositions.SECURITY, 25, DayOfWeeks, 19, null, null, new List<Shift>());

            Global.myManagement.AddEmployee("Georgi", "Obretenov", 3, +359123123, "Nqkudesi",
                                        ContractTypes.PART_TIME, 16, JobPositions.CASHIER, 25, DayOfWeeks, 19, null, null, new List<Shift>());

            Global.myManagement.AddEmployee("Tonkata", "Garboutchev", 4, +359123123, "Nqkudesi",
                                        ContractTypes.FULL_TIME, 16, JobPositions.WAREHOUSE_EMPLOYEE, 25, DayOfWeeks, 19, null, null, new List<Shift>());
            Global.myManagement.AddEmployee("Nik", "Spek", 5, +359123123, "Nqkudesi",
                                        ContractTypes.ZERO_HOURS, 16, JobPositions.WAREHOUSE_MANAGER, 25, DayOfWeeks, 19, null, null, new List<Shift>());

            Global.myManagement.AddEmployee("Averami", "Gurbami", 6, +359123123, "Nqkudesi",
                                            ContractTypes.ZERO_HOURS, 16, JobPositions.STORE_EMPLOYEE, 25, DayOfWeeks, 19, null, null, new List<Shift>());

            LoadingData();
        }

		static DateTime now = DateTime.Now;
		static DateTime startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek);
		DateTime endOfWeek = startOfWeek.AddDays(6);

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeesLb.SelectedItem != null)
            {
                var popupForm = new Form();

                // Create an instance of your user control
                var myUserControl = new EmployeeUC();

                // Set any properties or values on your user control here
                // ...

                // Add your user control to the form's Controls collection
                popupForm.Controls.Add(myUserControl);

                // Set the properties of the form to make it look like a popup
                popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                popupForm.StartPosition = FormStartPosition.CenterParent;

                // Display the form as a modal dialog
                popupForm.ShowDialog();
                MessageBox.Show(employees[0].ShiftsDates.ToString());
            }
        }

        public void LoadingData()
        {
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

            foreach (var employee in Global.myManagement.GetEmployees())
            {
                employeesLb.Items.Add(employee);
            }

            foreach (var shiftType in Enum.GetValues(typeof(ShiftTypes)))
            {
                shiftTypeCb.Items.Add(shiftType);
            }

			foreach (var jobPosition in Enum.GetValues(typeof(JobPositions)))
			{
				jobPositionsFilterCb.Items.Add(jobPosition);
			}

            foreach (var contract in Enum.GetValues(typeof(ContractTypes)))
            {
                contractTypeFilterClb.Items.Add(contract);
            }
        }

        public void RefreshData()
        {
            employeesLb.Items.Clear();
            LoadingData();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
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

                Global.myManagement.AddEmployee(firstName, lastName, bsn, telNubmer, address, contractType, workingHoursPerWeek, jobPosition, wage, daysOff, age, null, null, new List<Shift>());

                RefreshData();
            }
            catch (FormatException)
            {
                MessageBox.Show("To add an employee, please complete the required fields!");
            }
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int bsn = int.Parse(bsnRemoveTb.Text);
            Employee empToRemove = Global.myManagement.GetEmployeeByBcn(bsn);
            bool isBscnAssigned = employees.Any(e => e.BSN == bsn);

            if (!isBscnAssigned)
            {
                MessageBox.Show($"Can't remove employee due to non-existing BSN");
            }
            else
            {


                employees.Remove(empToRemove);
            }

            RefreshData();
        }

        private void hoursPerWeekTb_TextChanged(object sender, EventArgs e)
        {

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
                Employee searchedEmployee = Global.myManagement.GetEmployeeByBcn(bsn);
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
				Days calendarDays = new Days();
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
				Days calendarDays = new Days();
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
				using (CalendarPopUp createTask = new CalendarPopUp())
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
            try
            {
                Global.myManagement.AddShift(shiftDayPicker.Value, int.Parse(shiftBsnTb.Text), (ShiftTypes)shiftTypeCb.SelectedItem);
                RefreshData();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in the BSN box!");
            }
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


        private void SeeItemsButton_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (ItemsPopUp createTask = new ItemsPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.CenterScreen;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
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
    }
}


