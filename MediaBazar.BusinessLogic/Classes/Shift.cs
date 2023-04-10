using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MediaBazar.BusinessLogic.Classes.MyEnums;


namespace MediaBazar.BusinessLogic.Classes
{
    public class Shift
    {
        private DateTime shiftDate;
        private ShiftTypes shiftType;
        private bool attendedShift;
      
        public Shift(DateTime shiftDate, ShiftTypes shiftType, bool? attendedShift)
        {
            ShiftDate = shiftDate;
            ShiftType = shiftType;
            AttendedShift= (bool)attendedShift;
        }

        public DateTime ShiftDate { get { return shiftDate; }
            private set { shiftDate = value; } }
        public ShiftTypes ShiftType { get { return shiftType; }
            private set { shiftType = value; } }

		public bool AttendedShift { get => attendedShift; set => attendedShift = value; }

		public override string ToString()
        {
            if (ShiftDate == null)
            {
                return "";
            }else
            return $"{ShiftDate.ToString("d")} - {ShiftType} - {AttendedShift}";
        }
    }
}
