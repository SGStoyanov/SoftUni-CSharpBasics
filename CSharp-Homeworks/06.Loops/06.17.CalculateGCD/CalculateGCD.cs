// Problem 17.	* Calculate GCD
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm 
// (find it in Internet). 

using System;

class CalculateGCD
{
    static void Main()
    {
        while (true)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            int remain = a % b;
            while (remain != 0)
            {
                a = b;
                b = remain;
                remain = a % b;
            }
            Console.WriteLine(Math.Abs(b));
        }
    }
}