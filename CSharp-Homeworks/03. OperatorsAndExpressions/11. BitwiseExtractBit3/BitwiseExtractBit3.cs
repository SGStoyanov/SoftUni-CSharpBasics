/* Problem 11.	Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. */

using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Number: ");
            string getNum = Console.ReadLine();
            uint num = uint.Parse(getNum);

            uint controlBit = 1 << 3;
            uint resultBit = num & controlBit;

            if (resultBit == 0)
            {
                Console.WriteLine("The third bit of number {0} is 0", getNum);
            }
            else
            {
                Console.WriteLine("The third bit of number {0} is 1", getNum);
            }
        }
    }