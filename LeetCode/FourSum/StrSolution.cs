using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSum
{
    internal class StrSolution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) && string.IsNullOrEmpty(needle)) return 0;

            if (string.IsNullOrEmpty(needle)) return -1;

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if(StringCampare(haystack.Substring(i, needle.Length), needle))
                        return i;
                }
            }

            bool StringCampare(string source, string destination) => string.Equals(source, destination);
            
            return -1;
        }


    }
}
