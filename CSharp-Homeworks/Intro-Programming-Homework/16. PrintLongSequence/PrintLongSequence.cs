/*Problem 16.	* Print Long Sequence
Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
You might need to learn how to use loops in C# (search in Internet).*/

using System;
    class PrintLongSequence
    {
        static void Main()
        {
            int number1 = 2;
            int number2 = -3;
            for (int i = 1; i <= 500; i++)
            {
                Console.WriteLine("{0}, {1}", number1, number2);
                number1 += 2;
                number2 -= 2;
            }
        }
    }