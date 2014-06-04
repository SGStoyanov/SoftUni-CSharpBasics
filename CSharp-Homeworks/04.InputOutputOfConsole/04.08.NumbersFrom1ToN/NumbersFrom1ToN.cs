/*Problem 8.	Numbers from 1 to n
Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
each on a single line. Note that you may need to use a for-loop.*/

using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("n: ");
            string numPrompt = Console.ReadLine();
            int stringToInt = int.Parse(numPrompt);

            for (int i = 1; i <= stringToInt; i++)
            {
                Console.WriteLine(i);
            }
        }
    }