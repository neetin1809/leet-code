using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff_Betn_Two_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a";
            string t = "aa";

            //1st solution

            char dd = t[0];
             dd= t.ToCharArray().Except(s.ToCharArray()).FirstOrDefault();
            dd = char.MinValue == dd ? t[0] : dd;
             Console.WriteLine("{0}",dd);
            
            //2ND SOLUTION
            /*
            var s1 = s.ToCharArray();
            var t1 = t.ToCharArray();
            Array.Sort<char>(s1);
            Array.Sort<char>(t1);

            for (var i = 0; i < Math.Min(s1.Length, t1.Length); i++)
            {
                if (s1[i] != t1[i])
                {
                    Console.WriteLine("{0}", t1[i]);
                }
            }
            Console.WriteLine("{0}", t1[t1.Length - 1]);
            */
            /*
            int[] counts = new int[26];
            foreach (char c in t)
            {
                counts[c - 'a']++;
            }
            foreach (char c in s)
            {
                counts[c - 'a']--;
            }

            char x = '#';
            for (int i = 0; i < 26; i++)
            {
                if (counts[i] == 1)
                {
                    x = (char)('a' + i);
                    break;
                }
            }*/


            Console.ReadLine();

        }
    }
}
