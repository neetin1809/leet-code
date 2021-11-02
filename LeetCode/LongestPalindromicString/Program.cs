using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicString
{
    class Program
    {
        /// <summary>
        /// babad O/P aba bab
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", LongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth"));
            Console.ReadKey();
        }

        /// <summary>
        /// Used to find the longest palindromic string
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string LongestPalindrome(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue))
                return string.Empty;

            string tempInput = string.Empty;
            List<String> palinStr = new List<string>();
            try
            {

                for (int i = 0; i < inputValue.Length; i++)
                {
                    for (int j = i + 1; j <= inputValue.Length; j++)
                    {
                        tempInput = inputValue.Substring(i, j - i).ToString();

                        if (string.Equals(tempInput, StringReverse(tempInput)))
                            palinStr.Add(tempInput);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return palinStr.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
        }

        public static string StringReverse(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
            else
                return str;
        }


    }
}
