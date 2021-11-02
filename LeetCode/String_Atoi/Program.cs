using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_Atoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("-5-"));
            Console.ReadKey();
        }

        public static int MyAtoi(string str)
        {
            
            int num = 0;
            long number = 0;
            str = (str ?? string.Empty).Trim();
            string numStr = !string.IsNullOrEmpty(str) && str.TrimStart().Contains(" ") ? str.Split(' ')[0] : str;
            StringBuilder Sb = new StringBuilder();
            int sign = str[0] == '-' ? -1 : 1;
            long tmp = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if ((str[i] >= 48 && str[i] <= 57) || (((str[i] == 45) || (str[i] == 43)) && i == 0))
                {
                    
                    number = number * 10 + (int)(str[i]);
                    tmp = number * sign;
                    if (tmp < int.MinValue)
                    {
                        return int.MinValue;
                    }

                    if (tmp > int.MaxValue)
                    {
                        return int.MaxValue;
                    }
                }
                else
                    break;
            }
                
            //    // int.TryParse(numStr, out num);
            //}
            //catch (OverflowException e)
            //{
            //    num = numStr.StartsWith("-") ? int.MinValue : int.MaxValue;
            //}
           
            //catch (FormatException ex)
            //{

            //}
            //Regex re = new Regex(@".\d+");
            //Match m = re.Match(numStr);
            //if (m.Success)
            //    numStr = m.Value;
              
                   
            //}
            return (int)tmp;
        }
    }
}
