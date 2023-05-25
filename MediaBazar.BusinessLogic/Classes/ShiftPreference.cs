using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
    public class ShiftPreference
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public MyEnums.ShiftTypes Preference { get; set; }

        public ShiftPreference(int year, int month, MyEnums.ShiftTypes preference)
        {
            Year = year;
            Month = month;
            Preference = preference;
        }
        public ShiftPreference()
        {

        }
    }
}
