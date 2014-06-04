using System;
using System.Collections.Generic;
using System.Linq;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] catsScores = new int[11];
        for (int i = 0; i < n; i++)
        {
            byte vote = byte.Parse(Console.ReadLine());
            catsScores[vote]++;
        }
        int bestCatScore = int.MinValue;
        int indexOfBestCat = 1;

        for (int i = 1; i <= 10; i++)
        {
            if (catsScores[i] > bestCatScore)
            {
                bestCatScore = catsScores[i];
                indexOfBestCat = i;
            }
        }

        Console.WriteLine(indexOfBestCat);
    }
}