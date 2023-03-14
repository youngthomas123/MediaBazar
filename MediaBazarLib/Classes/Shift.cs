using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static S2GroupProject.Classes.MyEnums;

namespace MediaBazarLib.Classes
{
    public class Shift
    {
        private DateTime shiftDate;
        private ShiftTypes shiftType;
      
        public Shift(DateTime shiftDate, ShiftTypes shiftType)
        {
            ShiftDate = shiftDate;
            ShiftType = shiftType;
        }

        public DateTime ShiftDate { get { return shiftDate; }
            private set { shiftDate = value; } }
        public ShiftTypes ShiftType { get { return shiftType; }
            private set { shiftType = value; } }

        public override string ToString()
        {
            if (ShiftDate == null)
            {
                return "";
            }else
            return $"{ShiftDate.ToString("d")} - {ShiftType}";
        }
    }
}
