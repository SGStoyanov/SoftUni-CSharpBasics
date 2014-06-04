//Problem 13.	Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given 
//integer number n has value of 1. 

using System;

    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("Number: ");
            string numPrompt = Console.ReadLine();
            int num = int.Parse(numPrompt);

            Console.Write("Position: ");
            string posPrompt = Console.ReadLine();
            int pos = int.Parse(posPrompt);

            int ctrlBit = num >> pos;
            int result = ctrlBit & 1;
            bool boolCheck = result == 1;

            if (boolCheck)
            {
                Console.Write("Bit at position {0} = 1: {1}.", pos, boolCheck);
            }
            else
            {
                Console.Write("Bit at position {0} = 1: {1}.", pos, boolCheck);
            }
            Console.WriteLine();
        }
    }