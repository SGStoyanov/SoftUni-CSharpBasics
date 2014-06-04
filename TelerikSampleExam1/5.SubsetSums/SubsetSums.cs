using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        while (true)
        {
            long s = long.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            List<long> foundNumbers = new List<long>();
            for (int i = 0; i < numbers.Length; i++)
            {
                foreach (var item in numbers)
                {
                    if (numbers[i] + item == s)
                    {
                        foundNumbers.Add(numbers[i]);
                        foundNumbers.Add(item);
                    }
                }
                if (numbers[i] == s)
                {
                    foundNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(foundNumbers.Count());    
        }
        
    }
}