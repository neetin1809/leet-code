using System;

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
            if (bracketPairs.keys.contains(c))
                brackets.push(c);
            else
            {
                if (bracketPairs.values.contains(c))
                {
                    if (c == bracketPairs[brackets.first()])
                        brackets.pop();
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
        return brackets.count() == 0;
    }
}
