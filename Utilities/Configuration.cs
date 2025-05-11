using System;
using System.Collections.Generic;
using System.Linq;

namespace HalcyonCore.Utilities
{
    public static class Configuration
    {
        //generates a new random string
		public static string CreateRandomNumericString()
		{
			var rand = new Random();
			string newId = "";
			for (int ctr = 0; ctr <= 2; ctr++)
			{
				newId += rand.Next(10000).ToString();
			}
			return newId.Substring(0, 6);
		}

        public static IEnumerable<IEnumerable<T>> SplitCollection<T>(IEnumerable<T> list, int parts)
        {
            int i = 0;
            var splits = from item in list
                         group item by i++ % parts into part
                         select part.AsEnumerable();
            return splits;
        }

        public static int[] RandomizeArray(int amount)
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
