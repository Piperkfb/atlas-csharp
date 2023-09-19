using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Method of operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the max number in a list
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count <= 0)
                return(0);
            int maxi = nums[0];
            foreach(int i in nums)
            {
                if (i > maxi)
                    maxi = i;
            }
            return(maxi);
        }
    }
}