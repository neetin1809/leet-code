using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagConversionReading
{
    class Program
    {
        public struct Point
        {
            public int x;
            public int y;
        }
        public static Point GetNextPointFrom(int pX, int pY, int numRows)
        {
            if (pY == numRows - 1)
            {
                //Increase X
                //Decrease Y
                return new Point { x = pX + 1, y = pY - 1 };
            }

            else if (pY == 0)
            {
                return new Point { x = pX , y = pY + 1 };
            }
            else
            {
                if (pX %(numRows-1)==0)
                {

                    return new Point { x = pX, y = pY + 1 };
                }
                else
                    return new Point { x = pX + 1, y = pY - 1 };


            }
        }

        public static string Convert(string s,int numRows)
        {
            if (numRows == 1)
                return s;
            if (s.Length <= numRows)
                numRows = s.Length;
            Point p = new Point { x = 0, y = 0 };
            string[] grid = new string[numRows];

            for (int i = 0; i < s.Length; i++)
            {
                grid[p.y] = grid[p.y] + s[i];
                p = GetNextPointFrom(p.x, p.y, numRows);
            }
            return string.Join("", grid);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(Convert("PAYPALISHIRING", 4));
            Console.ReadLine();
        }
    }
}
