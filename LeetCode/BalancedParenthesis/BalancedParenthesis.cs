using System.Collections.Generic;
using System.Linq;

public sealed class BalancedParenthesis
{
    public static bool IsBalanced(string input)
    {
        Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
        {
            { '{','}' },
            { '(',')' },
            { '[',']' },
            { '<','>' }
        };

        Stack<char> brackets = new Stack<char>();
        foreach (char c in input)
        {
            if (bracketPairs.Keys.Contains(c))
                brackets.Push(c);
            else
            {
                if (bracketPairs.Values.Contains(c))
                {
                    if (c == bracketPairs[brackets.First()])
                        brackets.Pop();
                    else
                        return false;
                }
                else
                {
                    //Words should be considered
                    continue;
                }
            }
        }
        return brackets.Count() == 0;
    }
}
