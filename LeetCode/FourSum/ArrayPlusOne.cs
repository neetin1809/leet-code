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
                while(length >= 0)
                {

                    if (plusOne > 9)
                    {
                        // For 9 or 19
                        if(length == 0)
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
    }
}
