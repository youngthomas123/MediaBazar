using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.BusinessLogic.Dtos;

namespace MediaBazar.BusinessLogic.Containers
{
    public class StatisticsContainer: IStatisticsContainer
    {
        private readonly IStatisticsDataAccess _statisticsDataAccess;
        
    
        public StatisticsContainer(IStatisticsDataAccess statisticsDataAccess)
        {
            _statisticsDataAccess = statisticsDataAccess;
        }

        public void LoadDataIntoColumns(string ChartData)
        {
            _statisticsDataAccess.LoadDataIntoColumns(ChartData);
        }
        public double ShowShiftAttendance()
        {
            return _statisticsDataAccess.ShowShiftAttendance();
        }

        public ItemStatsDto GetItemStatsDto(string category)
        {
           

            int[] SalesPerMonth = new int[12];


            for (int i = 1; i <= 12;i++)
            {
                SalesPerMonth[i-1] =_statisticsDataAccess.NumberOfSales(i, category);
            }

            ItemStatsDto itemStatsDto = new ItemStatsDto();
            itemStatsDto.Category = category;
            itemStatsDto.Jan = SalesPerMonth[0];
            itemStatsDto.Feb = SalesPerMonth[1];
            itemStatsDto.Mar = SalesPerMonth[2];
            itemStatsDto.Apr = SalesPerMonth[3];
            itemStatsDto.May = SalesPerMonth[4];
            itemStatsDto.Jun = SalesPerMonth[5];
            itemStatsDto.Jul = SalesPerMonth[6];
            itemStatsDto.Aug = SalesPerMonth[7];
            itemStatsDto.Sep = SalesPerMonth[8];
            itemStatsDto.Oct = SalesPerMonth[9];
            itemStatsDto.Nov = SalesPerMonth[10];
            itemStatsDto.Dec = SalesPerMonth[11];

            return itemStatsDto;
        }
    }
   
}
