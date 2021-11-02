using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Of_Two_Numbers
{
    class Program
    {
        public static int desired;
        
        static void Main(string[] args)
        {
            int n;
            n = 19;
            int sum = 0;
            while(sum != 1)
            {

            }
        }

        static void Main1(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            var xx = TwoSum(new int[] { 1,3,5,7,9 }, 8);
            xx.ToList().ForEach(n => Console.Write($" {n}"));
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static int[] TwoSumOne1(int[] numbers, int target)
        {
            int[] ret = new int[2];
            HashSet<int> arr = new HashSet<int>(numbers);
            //for (int i = 0; i < arr.Count; i++)
            //{
            //     desired = target - numbers[i};
            //    if(arr.Contains(desired) && numbers.
              
            //}
            return ret;
        }

        public static int[] TwoSum(int[] numbers, int target)
            {
                int[] ret = new int[2];
                int start = 0;
                int end = numbers.Length - 1;

                while (start <= end)
                {
                    Console.WriteLine($"start :{start} end:{end} sum:{numbers[start] + numbers[end]} desired:{target}");
                    if ((numbers[start] + numbers[end]) == target)
                    {
                        ret[0] = start;
                        ret[1] = end;
                        break;
                    }
                    else if ((numbers[start] + numbers[end]) > target)
                    {
                        Console.WriteLine("Gone in decrement end");
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                }

                return ret;
            }
        }
}
