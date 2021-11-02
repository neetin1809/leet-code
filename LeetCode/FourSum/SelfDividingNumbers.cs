using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    //https://leetcode.com/problems/self-dividing-numbers/
    public class SelfDividingNumbersClass
    {
        public SelfDividingNumbersClass()
        {
        }

        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> result = new List<int>();
            
            while (left <= right)
            {

                    string numStr = left.ToString();

                    if (!numStr.Contains('0'))
                    {
                        for ( int i=0; i< numStr.Length; i++)
                        {
                            if(left %( int .Parse(numStr[i].ToString())) != 0 )
                            {
                                break;
                            }
                            else if( i == numStr.Length - 1)
                            {
                                result.Add(left);
                            }
                        }
                    }

                    left += 1;
                
            }

            return result;
        }

    }
}
