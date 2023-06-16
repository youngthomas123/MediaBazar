using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Classes
{
	public class Sorting
	{
		public List<T> InsertionSort<T>(List<T> list) where T : IComparable<T>
		{
			for (int i = 1; i < list.Count; i++)
			{
				T key = list[i];
				int j = i - 1;

				while (j >= 0 && list[j].CompareTo(key) > 0)
				{
					list[j + 1] = list[j];
					j--;
				}
				list[j + 1] = key;
			}
			return list;
		}
	}
}
