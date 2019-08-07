using System;

namespace Assignment2
{
    class Chessboard
    {
        static void Main(string[] args)
        {
            int outer, inner;
            for (outer = 1; outer<= 8; outer++)
            {
                for (inner = 1; inner <= 8; inner++)
                    if (outer % 2 == 0 && inner % 2 == 0)
                    {
                        Console.Write("x");
                    }
                    else if (outer % 2 != 0 && inner % 2 != 0)
                    {
                        Console.Write("x");
                    }
                    else if (outer % 2 == 0 && inner % 2 != 0)
                    {
                        Console.Write("0");
                    }
                    else if (outer % 2 != 0 && inner % 2 == 0)
                    {
                        Console.Write("0");
                    }
                Console.WriteLine("");
            }


        }
    }
}
