//Problem 7. Sum of 5 Numbers Write a program that enters 5 numbers (given in a single line, separated by a space), 
//calculates and prints their sum

using System;

    class SumOf5Nums
    {
        static void Main()
        {
            string nums = Console.ReadLine();
            string[] splitNums = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < splitNums.Length; i++)
            {
                sum = sum + double.Parse(splitNums[i]);
            }
            Console.WriteLine(sum);
        }
    }