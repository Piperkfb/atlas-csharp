using System;

namespace MyMath
{
    public class Operations
    {
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