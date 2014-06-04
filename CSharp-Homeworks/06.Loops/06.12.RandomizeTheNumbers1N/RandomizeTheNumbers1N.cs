// Problem 12.	* Randomize the Numbers 1…N
// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

using System;
using System.Linq;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        while (true)
        {
            Console.Write("n: ");
            int num = int.Parse(Console.ReadLine());
            bool[] printedNums = new bool[num + 1];
            Random randNum = new Random();
            int numToPrint;

            for (int i = 1; i <= num; i++)
            {
                numToPrint = randNum.Next(1, num + 1);
                if (!printedNums[numToPrint])
                {
                    Console.Write(numToPrint + " ");
                    printedNums[numToPrint] = true;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();
        }
    }
}