/* Problem 14.	Decimal to Binary Number
Using loops write a program that converts an integer number to its binary representation. The input is entered as long. 
The output should be a variable of type string. Do not use the built-in .NET functionality. */

using System;

class DecimalToBinaryNum
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Decimal: ");
            long decNumber = long.Parse(Console.ReadLine());
            string binNum = "";

            if (decNumber == 0)
            {
                Console.Write("Binary: " + decNumber);
            }
            else
            {
                while (decNumber != 0)
                {
                    int reminder = (int)decNumber % 2;
                    binNum = reminder + binNum;
                    decNumber /= 2;
                }
                Console.WriteLine("Binary: " + binNum);
            }
        }
    }
}