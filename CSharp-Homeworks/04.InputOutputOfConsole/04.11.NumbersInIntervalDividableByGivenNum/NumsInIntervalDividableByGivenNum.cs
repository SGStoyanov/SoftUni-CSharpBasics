/*Problem 11. Numbers in Interval Dividable by Given Number
Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
the reminder of the division by 5 is 0.*/

using System;

    class NumsInIntervalDividableByGivenNum
    {
        static void Main()
        {
            Console.Write("Num1: ");
            string num1Prompt = Console.ReadLine();
            int num1 = int.Parse(num1Prompt);
            Console.Write("Num2: ");
            string num2Prompt = Console.ReadLine();
            int num2 = int.Parse(num2Prompt);

            int p = 0;
            if (num1 > num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    int result = i % 5;
                    if (result == 0)
                    {
                        p += 1;
                    }
                }
                Console.Write("p = " + p + "\n");
            }
            

            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    int result = i % 5;
                    if (result == 0)
                    {
                        p += 1;
                    }
                }
                Console.Write("p = " + p + "\n");
            }
            if (num1 == num2)
            {
                Console.WriteLine("There is no dividible difference between the numbers {0} and {1}.", num1, num2);
                Console.Write("p = " + p + "\n");
            }
        }
    }