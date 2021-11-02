using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -120;
            try
            {
            checked
            {
                    string s = string.Join("", Math.Abs(n).ToString().Reverse());
                    if (n < 0)
                        s = String.Format("{0}{1}", "-", s);
                    Console.WriteLine($"{Convert.ToInt32(s)}");

            }
            }
            catch(OverflowException e)
            {
                //return 0;
            }
            Console.ReadKey();

        }
    }
}
