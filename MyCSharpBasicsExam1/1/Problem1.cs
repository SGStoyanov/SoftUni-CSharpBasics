using System;
using System.Collections.Generic;
using System.Linq;

class Problem1
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int[] xCoordinates = new int[5];
        int[] yCoordinates = new int[5];

        for (int index = 0; index < 5; index++)
        {
            xCoordinates[index] = int.Parse(Console.ReadLine());
            yCoordinates[index] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if ((xCoordinates[i] <= 3 * h && xCoordinates[i] >= 0) && (yCoordinates[i] >= 0 && yCoordinates[i] <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((xCoordinates[i] <= 2 * h && xCoordinates[i] >= h) && (yCoordinates[i] >= 0 && yCoordinates[i] <= 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}