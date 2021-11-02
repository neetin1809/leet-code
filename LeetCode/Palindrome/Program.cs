using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int rem, orig, num=0;
            orig = x;
            while (x != 0)
            {
                rem = x % 10;
                num =( num * 10) + rem;
                x =  x / 10;
            }
            return orig == num;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.IsPalindrome(10).ToString());
            Console.ReadKey();
        }
    }
}
