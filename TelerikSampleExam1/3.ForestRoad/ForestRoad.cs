using System;
using System.Collections.Generic;
using System.Linq;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int rowIndex = 1; rowIndex <= n; rowIndex++)
        {
            for (int colIndex = 1; colIndex <= n; colIndex++)
            {
                if (rowIndex == colIndex)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int rowIndex = n - 1; rowIndex >= 1; rowIndex--)
        {
            for (int colIndex = 1; colIndex <= n; colIndex++)
            {
                if (rowIndex == colIndex)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}