using System;
using System.Collections.Generic;
using System.Linq;

namespace HalcyonCore.Utilities
{
    public static class Extensions
    {
		public static IEnumerable<IEnumerable<T>> SplitCollection<T>(this IEnumerable<T> list, int parts)
		{
			int i = 0;
			var splits = from item in list
						 group item by i++ % parts into part
						 select part.AsEnumerable();
			return splits;
		}

		public static string LastDayInThisMonth(this DateTime providedDate)
		{
			try
			{
				DateTime endOfMonth = new DateTime(providedDate.Year, providedDate.Month, DateTime.DaysInMonth(providedDate.Year, providedDate.Month));
				return endOfMonth.ToString().Split(" ")[0];
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public static int[] RandomizeArray(this int amount)
		{
			var nums = Enumerable.Range(0, amount).ToArray();
			var rnd = new Random();

			// Shuffle the array
			for (int i = 0; i < nums.Length; ++i)
			{
				int randomIndex = rnd.Next(nums.Length);
				int temp = nums[randomIndex];
				nums[randomIndex] = nums[i];
				nums[i] = temp;
			}
			return nums;
		}
	}
}
