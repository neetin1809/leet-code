using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGigWinnerLoose
{
    class Program
    {
        static int noOfCases, noOfVillans;

        static void Main(string[] args)
        {
            List<int> villainPower, PlayerPower;
            List<string> result = new List<string>();


            Console.WriteLine("Enter number of test cases");
            noOfCases = Convert.ToInt32(Console.ReadLine());

            if (noOfCases > 10)
                Console.WriteLine("Test cases should be less then or equal to 10");

            Console.WriteLine("Enter number of villans");
            noOfVillans = Convert.ToInt32(Console.ReadLine());

            if (noOfVillans > 1000)
                Console.WriteLine("Number of villansshould  be less then or equal to 1000");

            int i = 0;
            do
            {
                villainPower = SetPower();
        
                PlayerPower = SetPower();

                for (int j = 0; j < noOfVillans; j++)
                {
                    if (PlayerPower[j] <= villainPower[j])
                    {
                        result.Add("loose");
                        break;
                    }

                    if (j == noOfVillans-1)
                        result.Add("Win");
                }

                i++;
            }
            while (i < noOfCases);

            result.ForEach(str => {
                Console.WriteLine(str);
            });

            Console.ReadKey();

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<int> SetPower()
        {
            List<int> power = new List<int>();
            for (int j = 0; j < noOfVillans; j++)
                power.Add(Convert.ToInt32(Console.ReadLine()));
            return power;

        }
    }
}
