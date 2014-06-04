// Problem 8. Catalan Numbers

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        while (true)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 1 && n < 100)
            {
                BigInteger numerator = 1;
                BigInteger denominator = 1;
                BigInteger result = 1;
                for (int k = 2; k <= n; k++)
                {
                    numerator *= n + k;
                    denominator *= k;
                }
                result = numerator / denominator;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Out of range");
            }  
        } 
    }
}