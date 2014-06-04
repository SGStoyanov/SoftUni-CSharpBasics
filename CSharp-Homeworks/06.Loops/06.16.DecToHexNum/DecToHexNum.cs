/* Problem 16.	Decimal to Hexadecimal Number
Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. 
The output should be a variable of type string. Do not use the built-in .NET functionality. */

using System;

class DecToHexNum
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Decimal: ");
            long decNumber = long.Parse(Console.ReadLine());
            string hexNum = "";

            if (decNumber == 0)
            {
                hexNum = "0";
            }
            else
            {
                while (decNumber > 0)
                {
                    long reminder = decNumber % 16;
                    decNumber /= 16;
                    switch (reminder)
                    {
                        case 10:
                            hexNum = "A" + hexNum;
                            break;
                        case 11:
                            hexNum = "B" + hexNum;
                            break;
                        case 12:
                            hexNum = "C" + hexNum;
                            break;
                        case 13:
                            hexNum = "D" + hexNum;
                            break;
                        case 14:
                            hexNum = "E" + hexNum;
                            break;
                        case 15:
                            hexNum = "F" + hexNum;
                            break;
                        default:
                            hexNum = reminder + hexNum;
                            break;
                    }
                }
            }
            Console.WriteLine("Hex: " + hexNum);
        }
    }
}