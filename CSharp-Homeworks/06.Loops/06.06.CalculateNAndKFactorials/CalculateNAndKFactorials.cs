/* Problem 6.	Calculate N! / K!
Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. */

using System;

class CalculateNAndKFactorials
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());

        if ((1 < k) & (n < 100) & (k < n))
        {
            ulong result = 1;
            for (int index = k + 1; index <= n; index++)
            {
                result *= (ulong)index;
            }
            Console.WriteLine("Sum: {0}", result);
        }
        else
        {
            Console.WriteLine("Out of range.");
        }
    }
}