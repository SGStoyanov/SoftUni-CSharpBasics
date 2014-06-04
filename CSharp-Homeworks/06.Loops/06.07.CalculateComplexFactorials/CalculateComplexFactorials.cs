// Problem 7. Calculate N! / (K! * (N-K)!)...

using System;

class CalculateComplesFactorials
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());

        if ((1 < k) & (n < 100) & (k < n))
        {
            int result1 = 1;
            int result2 = 1;
            int result;
            int count = 1;
            for (int index = n - k + 1; index <= n; index++)
            {
                result1 *= index;
                while (count <= k)
                {
                    result2 *= count;
                    count++;
                }
            }
            result = result1 / result2;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Out of range.");
        }
    }
}