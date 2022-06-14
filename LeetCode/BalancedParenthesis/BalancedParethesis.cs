using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParenthesis
{
    public sealed class BalancedParethesisTest
    {
        static Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
        {
            { '{', '}' },
            { '(', ')' },
            { '[', ']' },
            { '(', ')' }
        };

        public static bool IsBalanced(string input)
        {

            Stack<char> brackets = new Stack<char>();

            foreach (char ch in input)
            {
                if (bracketPairs.Keys.Contains(ch))
                {
                    brackets.Push(ch);
                }
                else
                {
                    if (bracketPairs.Values.Contains(ch))
                    {
                        if (ch == bracketPairs[brackets.First()])
                            brackets.Pop();
                        else
                            return false;
                    }
                    else
                    {
                        //to continue with words
                        continue;
                    }
                }

            }
            return brackets.Count == 0;
        }
    }
}
