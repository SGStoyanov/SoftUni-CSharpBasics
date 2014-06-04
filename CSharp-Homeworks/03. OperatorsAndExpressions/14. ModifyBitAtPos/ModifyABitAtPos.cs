using System;

    class ModifyABitAtPos
    {
        static void Main()
        {
            Console.Write("Number: ");
            string numPrompt = Console.ReadLine();
            int num = int.Parse(numPrompt);

            Console.Write("Position: ");
            string posPrompt = Console.ReadLine();
            int pos = int.Parse(posPrompt);

            Console.Write("0 or 1: ");
            string valPrompt = Console.ReadLine();
            int value = int.Parse(valPrompt);

            if (value == 1)
            {
                int setOne = 1 << pos;
                int foundBitOne = num | setOne;
                Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
                Console.WriteLine(foundBitOne);
            }
            else if (value == 0)
            {
                int setZero = ~(1 << pos);
                int foundBitZero = num & setZero;
                Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
                Console.WriteLine(foundBitZero);
            }
            else
            {
                Console.WriteLine("Wrong value!");
            }
        }
    }