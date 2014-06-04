/* Problem 3. Primes in Given Range Write a method that calculates all prime numbers in given range and returns them as list of integers:
static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all 
primes in their range, separated by a comma. */

using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        while (true)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNumber, endNumber);

            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
        }
    }

    public static List<int> FindPrimesInRange(int start, int end)
    {
        List<int> primes = new List<int>();

        if (start < 2)
        {
            start = 2;
        }
       
        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;
            for (int j = 2; (j * j) <= i; j++)
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }
        return primes;
    }
}