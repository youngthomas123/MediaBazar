using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
	public class SickLeave
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string? Reason { get; set; }
		public bool IsScheduled { get; set; }
        public string ManagerMessage { get; set; }
        public SickLeave(DateTime startDate, DateTime endDate, string? reason, bool isScheduled)
		{
			StartDate = startDate;
			EndDate = endDate;
			Reason = reason;
			IsScheduled = isScheduled;
			ManagerMessage = "";
		}

		public SickLeave()
		{

		}
		public override string ToString()
		{
			if (StartDate == null || EndDate == null)
			{
				return "";
			}else
			if (IsScheduled == false)
			{
				return $"From {StartDate.ToString("d")} to {EndDate.ToString("d")} because {Reason} - Not Approved";
			}
			else
			if(IsScheduled== true) 
			{
				return $"From {StartDate.ToString("d")} to {EndDate.ToString("d")} because {Reason} - Approved";
			}
			else
			{
				return "";
			}
			
        }
    }
}
