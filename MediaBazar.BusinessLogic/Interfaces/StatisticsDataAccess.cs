using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IStatisticsDataAccess
    {
        void LoadDataIntoColumns(string ChartData);
        double ShowShiftAttendance();
    }
}
