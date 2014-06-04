/*Problem 10.	Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
 (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you 
 may need to learn how to use loops. */

using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            for (long i = 0, previous = 0, current = 1, n = long.Parse(Console.ReadLine()); i < n; i++)
            {
                Console.Write("{0} ", previous);
                var temp = current;
                current += previous;
                previous = temp;
            }
            Console.WriteLine();
        }
    }