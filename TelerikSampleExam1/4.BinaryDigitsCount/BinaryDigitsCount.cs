using System;
using System.Collections.Generic;
using System.Linq;

class BinaryDigitsCount
{
    static void Main()
    {
        // Read input
        long b = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());

        // Solve
        for (int i = 1; i <= n; i++)
        {
            int count = 0;
            uint number = uint.Parse(Console.ReadLine());
            while (number != 0)
            {
                if ((number & 1) == b)
                {
                    count++;
                }
                number = number >> 1;
            }

            // Write answers
            Console.WriteLine(count);
        }
        
    }
}