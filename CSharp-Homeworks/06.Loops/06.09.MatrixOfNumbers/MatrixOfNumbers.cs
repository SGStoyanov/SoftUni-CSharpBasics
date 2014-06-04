// Problem 9.	Matrix of Numbers
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in 
// the examples below. Use two nested loops. 

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        while (true)
        {
            Console.Write("n: ");
            int num = int.Parse(Console.ReadLine());
            if (1 <= num && num <= 20)
            {
                Console.Clear();
                for (int row = 1; row <= num; row++)
                {
                    for (int column = 0; column < num; column++)
                    {
                        Console.Write(row + column + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Out of range.");
            }
        }
    }
}