using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonString
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = new string[] { "leets", "leetcode", "leetc", "leeds" };
            //args = new string[] { "dog", "racecar", "car", "leeds" };
            args = new string[] { "a","a","c" };
            args = new string[] { "" };

            Console.WriteLine(LongestCommonPrefix(args));
            Console.ReadKey();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            int start = 0, end = strs.Length - 1, mid, minLen;

            if (strs == null || strs.Length == 0)
                return "";

            minLen = strs.Aggregate((min, cur) => min.Length < cur.Length ? min : cur).Length;
            end = minLen;
            while (start <= end)
            {
                mid = (start + end) / 2;
                
                if (isCommonPrefix(strs, mid))
                    start = mid + 1;
                else
                    end = mid - 1;

            }
            return strs[0].Substring(0,((start + end)/2));
        }

        public static bool isCommonPrefix(String[] strs, int len)
        {
            len = len == 0  && strs[0].Length > 0 ? 1 : len;
            String str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1) || string.IsNullOrEmpty(str1))
                    return false;
            return true;
        }
    }
}