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

		public ItemStatsDto Electronics { get; set; }

        public ItemStatsDto Furniture { get; set; }

        public ItemStatsDto Gaming { get; set; }

        public ItemStatsDto Kitchen { get; set; }

        public ItemStatsDto Office_Supplies { get; set; }

        public ItemStatsDto Sports_outdoors { get; set; }

        public ItemStatsDto Clothing { get; set; }

        public ItemStatsDto Toys_Games{ get; set; }

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
           

            Electronics = _statisticsContainer.GetItemStatsDto("Electronics");
			Furniture = _statisticsContainer.GetItemStatsDto("Furniture");
			Gaming = _statisticsContainer.GetItemStatsDto("Gaming");
            Kitchen = _statisticsContainer.GetItemStatsDto("Kitchen");
			Office_Supplies = _statisticsContainer.GetItemStatsDto("Office Supplies");
			Sports_outdoors = _statisticsContainer.GetItemStatsDto("Sports & outdoors");
            Clothing = _statisticsContainer.GetItemStatsDto("Clothing");
			Toys_Games = _statisticsContainer.GetItemStatsDto("Toys & Games");

            Categories = _statisticsContainer.GetCategories();

            AttendancePercentage = _statisticsDataAccess.ShowShiftAttendance();
		}
	}
}
