/* Problem 4.	Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
Use a sequence of if operators. */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers (each on a separate line): ");
        float numA = float.Parse(Console.ReadLine());
        float numB = float.Parse(Console.ReadLine());
        float numC = float.Parse(Console.ReadLine());

        if ((numA > 0 && numB > 0 && numC > 0) || (numA < 0 && numB < 0 && numC > 0) || (numA > 0 && numB < 0 && numC < 0)
            || (numA > 0 && numB < 0 && numC > 0))
        {
            Console.WriteLine("Result: +");
        }
        else if (numA < 0 && numB < 0 && numC < 0)
        {
            Console.WriteLine("Result: -");
        }
        else if (numA == 0 || numB == 0 || numC == 0)
        {
            Console.WriteLine("Result: 0");
        }
        else
        {
            Console.WriteLine("Result: -");
        }
    }
}