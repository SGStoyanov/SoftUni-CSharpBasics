//Problem 5.	Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
using System.Text;

    class ThirdDigit7
    {
        static void Main()
        {
            uint intToCheck;
            int check = 7;
            Console.WriteLine("Provide a positive integer to check:");
            while (!uint.TryParse(Console.ReadLine(), out intToCheck)) //If the data entered is not a valid uint..
            {
                Console.WriteLine("Please, enter valid integer."); //..execute this.
            }
            int thirdIntInDigit = Convert.ToInt32(Math.Floor(intToCheck / Math.Pow(10, 2) % 10));
            Console.WriteLine("3rd digit in {0} is 7? - {1}", intToCheck, (thirdIntInDigit == check) ? "True" : "False");
        }
    }