/* Problem 3.	Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the 
number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. */ 

using System;
using System.Linq;

    class MinMaxSumAverageOfNNumbers
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("n: ");
                int intsCount;
                if ((!int.TryParse(Console.ReadLine(), out intsCount)) || (intsCount < 1))
                {
                    Console.WriteLine("You did it wrong. Try again.");
                }
                else
                {
                    int yourInt = 0;
                    int[] myArray = new int[intsCount];
                    for (int i = 0; i < intsCount; i++)
                    {
                        Console.Write("n" + i + ": ");
                        yourInt = int.Parse(Console.ReadLine());
                        myArray[i] = yourInt;
                    }
                    Console.WriteLine("min = " + myArray.Min());
                    Console.WriteLine("max = " + myArray.Max());
                    Console.WriteLine("sum = " + myArray.Sum());
                    Console.WriteLine("avg = {0:0.00}", myArray.Average());
                }
            }
        }
    }