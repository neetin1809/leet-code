using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(  RomanToInt("MCMXCIV"));
            Console.ReadKey();
        }
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> tokensValue = new Dictionary<char, int>
            {
                {'I',1    },
                {'V' ,5   },
                {'X' ,10  },
                {'L' ,50  },
                {'C' ,100 },
                {'D' ,500 },
                {'M' ,1000}
            };
            int i = 0, tempValue = 0;
            int res = 0, lastOne=0;

            while (i< s.Length)
            {
                if(tokensValue.ContainsKey(s[i]))
                {
                    tempValue=  tokensValue[s[i]];
                }
                res += tempValue;

                if (lastOne < tempValue)
                {
                    res += -(2* lastOne);

                }
              
                lastOne = tempValue;
                i++;
            }
            return res;

        }

    }
}
