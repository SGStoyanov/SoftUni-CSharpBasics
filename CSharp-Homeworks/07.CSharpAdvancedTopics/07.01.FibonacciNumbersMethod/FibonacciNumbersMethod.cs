// Problem 1.	Fibonacci Numbers
// Define a method Fib(n) that calculates the nth Fibonacci number. 

using System;

class FibonacciNumbersMethod
{
    static void Main()
    {
        while (true)
        {
            Console.Write("n = ");
            FibN(int.Parse(Console.ReadLine()));
        }
    }

    public static void FibN (int n)
    {
        long previous = 0;
        long current = 1;

        for (int i = 0; i < n; i++)
        {
            long temp = current;
            current += previous;
            previous = temp;
        }
        Console.WriteLine("Fib({0}) = {1}", n, current);
    }
}