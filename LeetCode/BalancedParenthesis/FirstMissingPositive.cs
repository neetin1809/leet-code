using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    //https://leetcode.com/problems/first-missing-positive/
    public class FirstMissingPositiveInCollection
    {
        public int FirstMissingPositive(int[] nums)
        {
            //3 4 -1 1
            int missing = 1;

            if (!nums.Any(x => x == missing))
                return missing;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                    continue;
                if (nums[i] == missing)
                {
                    missing++;
                }
                else if(nums[i] == missing + 1)
                {
                    return missing;
                }
            }
            return missing;
        }
    }
    }
}
