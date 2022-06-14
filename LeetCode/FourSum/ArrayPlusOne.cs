using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    public class ArrayPlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            int length = digits.Length - 1;
            int plusOne = ++digits[length];

            //To check For last Digit is 9
            if (plusOne > 9)
            {
                while (length >= 0)
                {

                    if (plusOne > 9)
                    {
                        // For 9 or 19
                        if (length == 0)
                        {
                            Array.Resize(ref digits, digits.Length + 1);
                            digits[0] = 0;
                            length++;
                        }
                        digits[length] = 0;
                        plusOne = ++digits[length - 1];
                        length--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                // 7 -> 8
                digits[length] = plusOne;
            }

            return digits;
        }

        //https://www.tutorialcup.com/leetcode-solutions/minimum-value-to-get-positive-step-by-step-sum-leetcode-solution.htm
        public static int minStartValue(int[] nums)
        {
            int min = 0, sum = 0;
            foreach (int num in nums)
            {
                sum = sum + num;
                min = Math.Min(min, sum);
                //min = sum>min?min: sum;
            }
            return Math.Abs(1 - min);
        }

        public IList<int> FindDuplicates(int[] nums)
        {
            //Variable to Hold Value
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //Considering negative Numbers as well 
                var possibleDup = Math.Abs(nums[i]);
                //Storing Number in That Index as well
                var possibleDuplicateIndex = possibleDup - 1;

                //If First Time Then Conevrting it into -ve
                if (nums[possibleDuplicateIndex] >= 0)
                {
                    nums[possibleDuplicateIndex] *= -1;
                }
                //We got duplicate numbers as well
                else
                {
                    result.Add(possibleDup);
                }
            }
            return result;
            //return nums.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).Where(x =>x.Value>1).Select(x=>x.Key).ToList();
        }
    }
}
