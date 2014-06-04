using System;
using System.Collections.Generic;
using System.Linq;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cableLength = new int[n];
        string[] measure = new string[n];

        for (int i = 0; i < n; i++)
        {
            cableLength[i] = int.Parse(Console.ReadLine());
            measure[i] = Console.ReadLine();
        }

        int totalLength = 0;
        int anotherCount = 0;
        for (int j = 0; j < cableLength.Length; j++)
        {
            if ((cableLength[j] >= 20 && measure[j] == "centimeters") || (cableLength[j] >= 0.2 && measure[j] == "meters"))
            {
                switch (measure[j])
                {
                    case "meters":
                        cableLength[j] = cableLength[j] * 100;
                        totalLength += cableLength[j];
                        break;
                    case "centimeters":
                        totalLength += cableLength[j];
                        break;
                    default:
                        break;
                }
                anotherCount++;
            }
        }
        totalLength = totalLength - ((anotherCount-1)*3);
        //Console.WriteLine("Total length: " + totalLength);
        int cablesCount = 0;
        int reminder = 0;

        if (totalLength % 504 == 0)
        {
            cablesCount = totalLength / 504;
        }
        else
        {
            reminder = totalLength % 504;
            cablesCount = totalLength / 504;
        }

        Console.WriteLine(cablesCount);
        Console.WriteLine(reminder);
    }
}