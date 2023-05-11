using MediaBazar.BusinessLogic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IStatisticsContainer
    {
        void LoadDataIntoColumns(string ChartData);
        double ShowShiftAttendance();

        ItemStatsDto GetItemStatsDto(string category);
    }
    
}
