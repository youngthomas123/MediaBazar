using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.BusinessLogic.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeWebsite.Pages
{
	public class CEOModel : PageModel
	{
		public string ChartData { get; set; }

		public List<string> Categories { get; set; }

		public ItemStatsDto UncategorizableItems { get; set; }
		public ItemStatsDto Electronics { get; set; }

		public ItemStatsDto Kitchen { get; set; }

		public ItemStatsDto Sports { get; set; }


		private readonly IStatisticsDataAccess _statisticsDataAccess;

		private readonly IStatisticsContainer _statisticsContainer;
		public CEOModel(IStatisticsDataAccess statisticsDataAccess, IStatisticsContainer statisticsContainer )
        {
			_statisticsDataAccess = statisticsDataAccess;  
			_statisticsContainer = statisticsContainer;
        }

		public double AttendancePercentage { get; private set; }

		public void OnGet()
		{
            UncategorizableItems = _statisticsContainer.GetItemStatsDto("null");
            Electronics = _statisticsContainer.GetItemStatsDto("electronics");
			Kitchen = _statisticsContainer.GetItemStatsDto("kitchen");
			Sports = _statisticsContainer.GetItemStatsDto("sports");

			Categories = _statisticsContainer.GetCategories();

            AttendancePercentage = _statisticsDataAccess.ShowShiftAttendance();
		}
	}
}
