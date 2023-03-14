using S2GroupProject.Classes;
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
		public DateTime Date { get; set; }
		public Days()
		{
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
			List<Employee> employees = Global.myManagement.GetEmployees();
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
	}
}
