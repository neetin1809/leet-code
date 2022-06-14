using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideTwoNumbers
{
    class Program
    {
        public static int divide(int dividend,int divisior)
        {
            long quotient = 0, temp = 0;
            int sign = ((dividend < 0) ^ (divisior < 0)) ? -1 : 1;

            dividend = Math.Abs(dividend);
            divisior = Math.Abs(divisior);

            //for (int i = 31; i >= 0; --i)
            //{
            //    if(temp+(divisior<<i)<= dividend)
            //    {
            //        temp += divisior << i;
            //        quotient |= 1L << i;
            //    }
            //}

            int partialSum, carry;
            do
            {
                partialSum = dividend ^ divisior;
                carry = (dividend & divisior) << 1;
                dividend = partialSum;
                divisior = carry;
            } while (carry != 0);
            return sign * partialSum;

           // return sign *(byte)quotient;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(divide(-10, -2));
            /*
            int num1, num2;
            num1 = 10;
            num2 = 9;
            num1 ^= num2;
            num2 ^= num1;
            num1 ^= num2;
            Console.WriteLine($" Numbers are {num1} & {num2}");
            */
            string msg = "This is a message";
            string key = ".";
            StringBuilder sb = new StringBuilder();

            foreach (char c in msg)
            {
                sb.Append((char)(c ^ key[0]));
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine((byte)(0<<5));
            Console.WriteLine(RemoveElement(new int[] { 1, 2, 2, 3 }, 2));
            Console.ReadKey();
        }

        //https://leetcode.com/problems/remove-element/
        public static int RemoveElement(int[] nums, int val)
        {
            
            short  count = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                //If Equal Don't swap
                if (nums[i] == val)
                {
                    continue;
                }
                else
                {
                    //Using C# 10 Features
                    (nums[i], nums[count]) = (nums[count], nums[i]);
                    count++;
                }
            }
            /*for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = '_';
                    count++;
                }
            }
            
            nums = nums.OrderBy(x => x).Skip(count).ToArray();
                //nums(x => x != -1);*/
            return nums.Length - count;
        }
    }

    //https://leetcode.com/problems/sqrtx/
    public static int MySqrt(int x)
    {
      ?
    }
}
