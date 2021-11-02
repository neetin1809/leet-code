using System;

namespace FizzBuzz_DesignPattern
{
    public interface IFizzBuzz
    {
    }

    public class NullBizzFuzz : IFizzBuzz
    {
        public static int value;
        public override string ToString()
        {
            return value.ToString();
        }
    }

    public class Buzz : IFizzBuzz
    {
        public override string ToString()
        {
            return "Buzz";
        }
    }

    public class Fizz : IFizzBuzz
    {
        public override string ToString()
        {
            return "Fizz";
        }
    }

    public class FizzBuzz : IFizzBuzz
    {
        public override string ToString()
        {
            return "FizzBuzz";
        }
    }

    public class FizzBuzzSolver
    {
        public int Fizz { get; }
        public int Buzz { get; }
        public int Iterations { get; }
        public int FizzBuzz { get; }
        public int Quotient { get; }
        public int Remainder { get; }

        public FizzBuzzSolver(int fizz, int buzz, int iterations, int fizzbuzz, int quotient, int remainder)
        {
            Fizz = fizz;
            Buzz = buzz;
            Iterations = iterations;
            FizzBuzz = fizzbuzz;
            Quotient = quotient;
            Remainder = remainder;
        }

        internal void Solve(Action<FizzBuzzSolver> fizzbuzz)
        {
            fizzbuzz(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 3;// int.Parse(Console.ReadLine());
            int buzz = 5;// int.Parse(Console.ReadLine());
            int iterations = 100;//int.Parse(Console.ReadLine());
            int fizzbuzz = fizz * buzz;
            int quotient = Math.DivRem(iterations, fizzbuzz, out var remainder);
            FizzBuzzSolver fb = new FizzBuzzSolver(fizz, buzz, iterations, fizzbuzz, quotient, remainder);
            switch (quotient)
            {
                case 0: fb.Solve(RemainderFizzBuzz); break;
                case 1: fb.Solve(NormalFizzBuzz); break;
                default: fb.Solve(CachedFizzBuzz); break;
            };

            Console.Read();

            Console.WriteLine("Hello World!");
        }

        private static Func<int, FizzBuzzSolver, string> isMatch = (i, fb) => i % fb.Fizz == 0 ? "Fizz" : i % fb.Buzz == 0 ? "Buzz" : $"{i}";     
        private static void NormalFizzBuzz(FizzBuzzSolver fb)
        {
            for (int i = 1; i < fb.FizzBuzz; i++)
            {
                Console.WriteLine(isMatch(i, fb));
            }
            Console.WriteLine("FizzBuzz");
            for (int i = fb.FizzBuzz + 1; i < fb.Iterations; i++)
            {
                Console.WriteLine(isMatch(i, fb));
            }
        }

        private static void CachedFizzBuzz(FizzBuzzSolver fb)
        {
            var fizzbuzzArray = new IFizzBuzz[fb.FizzBuzz];

            for (int i = 0; i < fb.FizzBuzz - 1; i++)
            {
                int s = i + 1;
                if (s % fb.Fizz == 0)
                {
                    fizzbuzzArray[i] = new Fizz();
                    Console.WriteLine("Fizz");
                }
                else
                if (s % fb.Buzz == 0)
                {
                    fizzbuzzArray[i] = new Buzz();
                    Console.WriteLine("Buzz");
                }
                else
                {
                    fizzbuzzArray[i] = new NullBizzFuzz();
                    Console.WriteLine(s);
                }

            }
            fizzbuzzArray[fb.FizzBuzz - 1] = new FizzBuzz();
            Console.WriteLine("FizzBuzz");
            NullBizzFuzz.value = fb.FizzBuzz;
            for (int j = 1; j < fb.Quotient; j++)
            {
                for (int i = 0; i < fb.FizzBuzz; i++)
                {
                    NullBizzFuzz.value++;
                    Console.WriteLine(fizzbuzzArray[i]);
                }

            }
            for (int i = 0; i < fb.Remainder; i++)
            {
                NullBizzFuzz.value++;
                Console.WriteLine(fizzbuzzArray[i]);
            }
        }

        private static void RemainderFizzBuzz(FizzBuzzSolver fb)
        {
            for (int i = 1; i <= fb.Remainder; i++)
            {
                Console.WriteLine(isMatch(i, fb));
            }
        }

    }
}
