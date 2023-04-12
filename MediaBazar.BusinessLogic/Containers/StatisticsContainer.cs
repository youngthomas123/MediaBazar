using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MediaBazar.BusinessLogic.Interfaces;

namespace MediaBazar.BusinessLogic.Containers
{
    public class StatisticsContainer: IStatisticsContainer, IStatisticsDataAccess
    {
        private readonly IStatisticsDataAccess _statisticsDataAccess;
        

        public void LoadDataIntoColumns(string ChartData)
        {
            _statisticsDataAccess.LoadDataIntoColumns(ChartData);
        }
        public double ShowShiftAttendance()
        {
            return _statisticsDataAccess.ShowShiftAttendance();
        }
    }
   
}
