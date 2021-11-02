using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Compress
{
    class Program
    {
        static void Main(string[] args)
        {
            //["a","a","b","b","c","c","c"]=>a2b2c2
            Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c','c' });
            Console.ReadKey();
        }

        private static int Compress(char [] chars)
        {
            string resStr="", str = string.Empty;
            //char[] ch = new char[] { "a", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b" };
            //ch = new string[] { "a" };
            str = string.Join("", chars);
            int length = chars.Length;

            for (int i = 0; i < length;)
            {
                int count = chars.Where(c => c == chars[i] ).Count();
                if (count > 1 && i != str.LastIndexOf(chars[i]))
                {
                    resStr = string.Format($"{resStr}{chars[i]}{count}");
                    i = str.LastIndexOf(chars[i])+1 ;
                }
                else
                {
                    resStr = string.Format($"{resStr}{chars[i]}");
                    i++;
                }
            }
            Console.WriteLine(resStr.Length + resStr);
            return resStr.Length;
        }
    }
}
