using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    public class PrimeNumber
    {
        public bool IsPrime(int n)
        {
            for (int i = 0; i < Math.Sqrt(n); i++)
            {
                if ( n%i == 0)
                    return false;
            }
            return true;
        }

        Predicate<int> isPrime = n =>
        {
            for (int i = 0; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        };

        public int GetNthPrimeNumber(int n)
        {
            int index = 2;
            int primeCount = 0;
            while (index>0)
            {
                if (isPrime(index))
                {
                    primeCount++;
                    if (n == primeCount)
                    {
                        Console.WriteLine($"The {n}th prime number is {n}");
                        break;
                     }
                }
                index ++;
            }
            return index;
        }
    }
}
