using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
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

namespace S2GroupProject.Forms
{
	public partial class CalendarPopUp : Form
	{
        private readonly IServiceProvider _serviceProvider;

        //private DateTime _currentMonth;

        static DateTime currentDT = DateTime.Now;
		static int currentYear = currentDT.Year;
		static int currentMonth = currentDT.Month;
		public CalendarPopUp(IServiceProvider serviceProvider)
		{
            _serviceProvider = serviceProvider;

            InitializeComponent();
			//_currentMonth = DateTime.Today;
			//DisplayCalendar(_currentMonth);
			DisplayCalendar();
			
		}

		private void DisplayCalendar()
		{
			flowLayoutPanel1.Controls.Clear();

			monthLb.Text = currentYear + " " + DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);

			DateTime startOfTheMonth = new DateTime(currentYear, currentMonth, 1);
			int daysInMoth = DateTime.DaysInMonth(currentYear, currentMonth);
			int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) ;

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
			if (currentMonth == 1)
			{
				currentMonth = 13;
				currentYear--;
			}
			currentMonth--;
			DisplayCalendar();
			
		}

		private void nextBtn_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			if (currentMonth == 12)
			{
				currentMonth = 0;
				currentYear++;
			}
			currentMonth++;
			DisplayCalendar();
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
