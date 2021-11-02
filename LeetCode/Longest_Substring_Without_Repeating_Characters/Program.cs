using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
//    Input: "abcabcbb"
//Output: 3 
//Explanation: The answer is "abc", with the length of 3. 

        //Ex 2
//        Input: "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.
    class Program
    {
        public int LengthOfLongestSubstring(string s)
        {
            var strList = new List<string>();

            for (int startIndex = 0; startIndex < s.Length; startIndex++)
            {
                var list = new HashSet<char>();
                for (int j = startIndex; j < s.Length; j++)
                {
                    if (!list.Contains(s[j]))
                    {
                        list.Add(s[j]);
                    }
                    else
                    {
                        break;
                    }
                }

                var sbString = new StringBuilder();
                foreach (var item in list)
                {
                    sbString.Append(item);
                }

                strList.Add(sbString.ToString());
            }

            var maxLength = 0;

            for (int x = 0; x < strList.Count; x++)
            {
                if (maxLength < strList[x].Length)
                {
                    maxLength = strList[x].Length;
                }
            }

            return maxLength;
        }

        private static string LongestString(string inputValue)
        {
            var strList = new List<string>();

            for (int startIndex = 0; startIndex < inputValue.Length; startIndex++)
            {
                var list = new HashSet<char>();
                for (int j = startIndex; j < inputValue.Length; j++)
                {
                    if(!list.Contains(inputValue[j]))
                    {
                        list.Add(inputValue[j]);
                    }
                    else
                    {
                        break;
                    }
                }

                var sbString = new StringBuilder();
                foreach (var item in list)
                {
                    sbString.Append(item);
                }

                strList.Add(sbString.ToString());
            }

            var maxLength = 0;
            var finalString = string.Empty;

            for (int x = 0; x < strList.Count; x++)
            {
                if(maxLength< strList[x].Length)
                {
                    finalString = strList[x];
                    maxLength = strList[x].Length;
                }
            }

            return finalString;
        }


        public static bool HasConsecutiveChars(string source, int sequenceLength=2)
        {
            // should check sequence length

            // just repeating letters
            //return Regex.IsMatch(source, "([a-zA-Z])\\1{" + (sequenceLength - 1) + "}");
            //return !source.Where((c, i) => (i >= 2) && source[i - 1] == c && source[i - 2] == c).Any();
            return source.Where((c, i) => i == 1).Any();
            //Regex.Matches(source, substrtemp).Count
            // any character version
            // return Regex.IsMatch(source,"(.)\\1{"+ (sequenceLength - 1) + "}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LongestString("pwwkew"));
            return;


            int max = 0;
            int j = 0;
            string str = "dvdf";
            //List<String> substr = new List<string>();
            //Dictionary<string, int> substr = new Dictionary<string, int>();
            //Hashtable substr = new Hashtable();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int len = str.Length; try
            {

                for (int index = 0; index < len; index++)
                {
                    if (index > 5)
                        System.Diagnostics.Debugger.Break();
                    if (dict.ContainsKey(str[index]))
                    {
                        j = Math.Max(j, index+1);
                    }else
                    {
                        dict.Add(str[index], index);
                    }
                    max = Math.Max(max, index - j + 1);

                }
                Console.WriteLine("{0}", max);
            }
            catch (Exception)
            {
                Console.WriteLine("exce occu");

                //throw;
            }
            /*
            substr.ForEach(it =>
            {
                Console.WriteLine(it);
            });*/
            Console.ReadKey();
        }
    }
}
