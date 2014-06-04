// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not 
//divisible by 3 and 7, on a single line, separated by a space. 

using System;

    class NumsNotDivisibleBy3And7
    {
        static void Main()
        {
            while (true)  // Infinite loop, so we can input many numbers without restarting the program.
            {
                Console.Write("n: ");
                int number;
                if (!int.TryParse(Console.ReadLine(), out number) || number < 1) // Checking for a wrong input
                {
                    Console.WriteLine("Wrong data. Enter an integer bigger than 1.");
                }
                for (int i = 1; i <= number; i++) // Looping the numbers between 1 and n
                {
                    if (i % 3 != 0 && i % 7 != 0) // Checking if they are divisible to 3 and 7
                    {
                        Console.Write(" " + i + " "); // Printing if they are not
                    }
                }
                Console.WriteLine();
            } 
        }
    }