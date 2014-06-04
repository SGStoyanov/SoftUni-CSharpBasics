//Problem 12.	Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p. 

using System;

    class ExtractBitFromInt
    {
        static void Main()
        {
            Console.WriteLine("Number: ");
            string prompt = Console.ReadLine();
            int num = int.Parse(prompt);
            Console.WriteLine("Position: ");
            string promptPos = Console.ReadLine();
            int pos = int.Parse(promptPos);

            int controlBit = 1 << pos;
            int resultBit = controlBit & num;

            if (resultBit == 0)
            {
                Console.WriteLine("The bit of position {0} is 0.", pos);
            }
            else
            {
                Console.WriteLine("The bit of position {0} is 1.", pos);
            }
        }
    }