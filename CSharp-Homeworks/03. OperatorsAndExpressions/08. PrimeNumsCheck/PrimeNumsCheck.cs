using System;

    class PrimeNumsCheck
    {
        static void Main()
        {
            byte byteToCheck;
            Console.WriteLine("Number n (n ≤ 100): ");

            while ((!byte.TryParse(Console.ReadLine(), out byteToCheck)) || !(byteToCheck >= 0 && byteToCheck <= 100))
            {
                Console.WriteLine("Wrong data. Try again.");
            }
            byte prosto = 0;
            for (byte i = 2; i < byteToCheck; i++)
            {
                if (byteToCheck % i == 0)
                {
                    prosto = 1;
                    break;
                }
                if (byteToCheck % i != 0)
                {
                    prosto = 0;
                }
            }
            if (prosto == 0 && byteToCheck != 1 && byteToCheck != 0)
            {
                Console.WriteLine("The number {0} is prime.", byteToCheck);
            }
            else
            {
                Console.WriteLine("The number {0} is NOT prime.", byteToCheck);
            }
        }
    }