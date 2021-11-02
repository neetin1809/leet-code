using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var XX = FourSum(new int[] { 01, 0, -1, 0, -2, 2 },0);
            XX.ToList().ForEach(s =>
            {
                Console.WriteLine(s);
            });

            Console.ReadKey();
    }

        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result =new  List<IList<int>>();
            int counterlength = nums.Length - 3;
            int loopCounter = 0;

            do
            {
                int startNum = nums[loopCounter];
                int[] arr = nums.Skip(loopCounter + 1).Take(3).ToArray();
                int sum = startNum + arr.Sum();
                if(sum == target || sum.Equals(target))
                {
                    result.Add(new int[] { startNum, arr[0], arr[1], arr[2] });
                }

                loopCounter++;
            }
            while (loopCounter < counterlength);
            return null;
        }
    }
}
