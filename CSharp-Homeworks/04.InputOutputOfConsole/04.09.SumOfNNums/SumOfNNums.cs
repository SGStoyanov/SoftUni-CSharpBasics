/*Problem 9.	Sum of n Numbers
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
Note that you may need to use a for-loop. */

using System;

    class SumOfNNums
    {
        static void Main()
        {
            Console.Write("Numbers: ");
            string numPrompt = Console.ReadLine();
            String[] separator = numPrompt.Split(' ');
            float sum = 0;
            for (int i = 0; i < separator.Length; i++)
            {
                sum = sum + float.Parse(separator[i]);
            }
            Console.WriteLine("Sum: " + sum);
        }
    }