using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_combinations_of_a_phone_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(letterCombinations("45"));
            Console.ReadKey();
        }

        public static IList<String> letterCombinations(String digits)
        {

            String[] lookup = new String[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            IList<String> results = new List<String>();
             generate("", digits, lookup, 0, results);
            return results;
        }


        private static String generate(String prefix, String digits, String[] lookup, int index, IList<String> collector)
        {
            if (index == digits.Length) return prefix;

            int digit = Convert.ToInt32( Char.GetNumericValue(digits[index]));
            String chars = lookup[digit];
            index++;

            for (int i = 0; i < chars.Length; i++)
            {
                String result = generate(prefix + chars[i], digits, lookup, index, collector);
                if (result != null) collector.Add(result);
            }

            return null;
        }
    }
}
