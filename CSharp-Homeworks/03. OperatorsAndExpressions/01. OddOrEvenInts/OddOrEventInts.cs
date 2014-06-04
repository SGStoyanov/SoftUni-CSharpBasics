using System;

    class OddOrEvenInts
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            string prompt = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(prompt);
                if (number % 2 == 0)
                {
                    Console.WriteLine("Your number " + number + " is even!");
                }
                else
                {
                    Console.WriteLine("Your number " + number + " is odd!");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a real number!");
            }
        }
    }