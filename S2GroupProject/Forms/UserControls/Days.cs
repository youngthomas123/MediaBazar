
using MediaBazar.BusinessLogic.Classes;
using MediaBazar.BusinessLogic.Containers;
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

namespace S2GroupProject.Forms
{
	public partial class Days : UserControl
	{
        private readonly IEmployeeContainer _employeeContainer;
        private readonly IServiceProvider _serviceProvider;

        public DateTime Date { get; set; }
		public Days(IEmployeeContainer employeeContainer, IServiceProvider serviceProvider)
		{
            _employeeContainer = employeeContainer;
			_serviceProvider = serviceProvider;

            InitializeComponent();
		}

		private void Days_Load(object sender, EventArgs e)
		{

		}

		public void DaysForCal(int numday)
		{
			daysLb.Text = numday+"";	
		}
		//public void DaysForCal(int numday, bool isCurrentMonth)
		//{
		//	daysLb.Text = numday.ToString();
		//	if (!isCurrentMonth)
		//	{
		//		BackColor = Color.LightGray;
		//	}
		//}
		private void button1_Click(object sender, EventArgs e)
		{
			List<Employee> employees = _employeeContainer.GetEmployees();
			List<Employee> employeesWorkingThatDay = new List<Employee>();
			foreach (var emp in employees)
			{
				if (emp.ShiftsDates.Any(shift => shift.ShiftDate.DayOfWeek == Date.DayOfWeek))
				{
					employeesWorkingThatDay.Add(emp);
				}
				
			}
			MessageBox.Show($"The date for this day is {Date.ToShortDateString()} and there are {employeesWorkingThatDay.Count()} employees working");

		}

        private void SelectDate_DoubleClick(object sender, EventArgs e)
        {
			//SelectDateDoubleClick(sender);
			var date = SelectDateDoubleClick(sender);
			DateTime dateForUc = DateTime.Parse(date);
            //MessageBox.Show(SelectDateDoubleClick(sender));
            DaySchedule dayScheduleUC = new DaySchedule(_employeeContainer, dateForUc);
           

            // Create a Form to serve as the popup
            Form popupForm = new Form();
            popupForm.Controls.Add(dayScheduleUC); // Add the DayScheduleUC to the Form

            // Set the Form properties
            popupForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.Size = new Size((Point)dayScheduleUC.Size);

            // Show the Form as a dialog (blocking)
            popupForm.ShowDialog();

        }
		private string SelectDateDoubleClick(object sender)
		{
			return Date.ToString("dd/MM/yyyy");
		}
    }
}

