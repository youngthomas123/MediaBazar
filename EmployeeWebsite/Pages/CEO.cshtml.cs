using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MediaBazar.BusinessLogic.Interfaces;

namespace EmployeeWebsite.Pages
{
    public class CEOModel : PageModel
    {
        public string ChartData { get; set; }
		private readonly IStatisticsDataAccess _statisticsDataAccess;
		public CEOModel(IStatisticsDataAccess statisticsDataAccess)
        {
			_statisticsDataAccess = statisticsDataAccess;  
        }

		public double AttendancePercentage { get; private set; }

		public void OnGet()
		{
			AttendancePercentage = _statisticsDataAccess.ShowShiftAttendance();
		}
	}
}
