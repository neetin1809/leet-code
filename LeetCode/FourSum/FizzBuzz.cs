using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    public class FizzBuzz
    {
        public void DoFizzBuzz()
        {
            var combinations = new List<Tuple<int, string>>
            {
                new Tuple<int, string> (3, "Fizz"),
                new Tuple<int, string> (5, "Buzz"),
            };

            Func<int, int, bool> isMatch = (int i, int comb) => i % comb == 0;

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(string.Join("", combinations.Where(c => isMatch(i, c.Item1)).Select(c => c.Item2).DefaultIfEmpty($"{i}")));
            }
        }
    }
}
