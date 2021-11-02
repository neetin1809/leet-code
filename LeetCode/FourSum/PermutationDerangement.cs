using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    public class PermutationDerangement
    {
        //Tail Recursion
        public static int CountDer(int n)
        {
            if (n > 0 && n <3) return n-1;

            return CountDer(n - 1) * (CountDer(n - 1) + CountDer(n - 2));
        }
    }
}
