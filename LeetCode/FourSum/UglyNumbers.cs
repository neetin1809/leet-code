using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    public class UglyNumbers
    {
        public bool IsUgly(int num)
        {
            if (num == 0)
                return false;
            if (num == 1)
                return true;
            int quot =0;
            quot = isDivisible(num);
            if (quot!=num && quot != 0)
            {
                num = quot;
                return IsUgly(quot);
            }
           
             return false;
        }

        public int isDivisible(int num)
        {
            var quot = Math.DivRem(num, 2, out var rem);
            if (rem == 0)
                return quot;
            quot = Math.DivRem(num, 3, out  rem);

            if (rem == 0)
                return quot;
            quot = Math.DivRem(num, 5, out  rem);

            if (rem == 0)
                return quot;
            return num;
        }
    }
}