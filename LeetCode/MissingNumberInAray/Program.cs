using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberInAray
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> incompleteArr = new List<int>{ 0, 1, 2, 3, 5 };
            IEnumerable<int> completeArr = Enumerable.Range(0, 6);
            Console.WriteLine($"Missing Array:{incompleteArr.Count()}..complete Array:{completeArr.Count()}");

            /*
            //Solution 1
            IEnumerable<int> missArray= completeArr.Except(incompleteArr);

            missArray.ToList().ForEach(n =>
            {
                Console.WriteLine(n);
            });
            */
            /*
            //Solution 2
            int missSum = incompleteArr.Sum();
            int multipleMiss = 6 * 5 / 2;
            incompleteArr.ToList().ForEach(n => {
                multipleMiss = multipleMiss - n;
            });
            Console.WriteLine(multipleMiss);
            */

            /*
            //Solution 3
            int x1, x2;
            x1 = incompleteArr.First();
            x2 = 1;
            bool isExecuted = false;
            for (int i=1;i< incompleteArr.Count()+1 ; i++)
            {
                x1 = i < incompleteArr.Count() ?x1 ^ incompleteArr.ToArray()[i]: x1;
                if (isExecuted)
                {
                    x2 = x2 ^ i;
                }
                isExecuted = true;
            }
            Console.WriteLine(x1 ^x2);
            */


            int start, end, mid=0, missing, length;
            length = incompleteArr.Count();
            int[] arr = incompleteArr.ToArray();
            start = 0;
            end = length - 1;
            while((end-start)>1)
            {
                mid = (start + length) / 2;
                if ((arr[start] - start) != (arr[mid] - mid))
                    end = mid;
                else if ((arr[end] - end) != (arr[mid] - mid))
                    start = mid;
            }
            Console.WriteLine($"Mid ELement :{arr[mid]+1}");
            Console.ReadKey();

        }
    }
}
