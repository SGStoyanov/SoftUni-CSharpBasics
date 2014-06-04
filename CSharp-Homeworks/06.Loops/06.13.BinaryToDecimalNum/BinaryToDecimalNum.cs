// Problem 13.	Binary to Decimal Number
// Using loops write a program that converts a binary integer number to its decimal form. The input is entered as 
// string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

using System;

class BinaryToDecimalNum
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Binary num: ");
            string binaryNum = Console.ReadLine();
            long dec = 0;

            for (int i = 0; i < binaryNum.Length; i++)
            {
                if (binaryNum[binaryNum.Length - i - 1] == '0')
                    continue;
                {
                    dec += (long)Math.Pow(2, i);
                }
            }
            Console.Write("Decimal num: " + dec + "\n");   
        }
    }
}