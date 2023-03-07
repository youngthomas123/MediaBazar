using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2GroupProject.Classes
{
	public class MyEnums
	{
		public enum JobPositions
		{
			NONE,
			CASHIER,
			SECURITY,
			STORE_MANAGER,
			WAREHOUSE_EMPLOYEE,
			STORE_EMPLOYEE,
			WAREHOUSE_MANAGER
		}
		public enum ContractTypes
		{
			NONE,
			FULL_TIME,
			PART_TIME,
			ZERO_HOURS
		}

		public enum ShiftTypes
		{
			NONE,
			MORNING,
			EVENING,
			NIGHT
		}
	}
}
