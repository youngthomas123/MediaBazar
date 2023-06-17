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

        int NumberOfSales(int month, string category);

        int NumberOfSalesPerYer(int month, string category, int year);
    }
}
