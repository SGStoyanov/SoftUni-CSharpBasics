/*Problem 6.	Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).*/

using System;

    class FourDigitNum
    {
        static void Main()
        {
            Console.WriteLine("Enter a four digit number between 1000 and 9999: ");
            string prompt = Console.ReadLine();
            try
            {
                ushort myUshortPrompt = Convert.ToUInt16(prompt);
                if (myUshortPrompt > 999 && myUshortPrompt < 10000)
                {
                    ushort thousands = Convert.ToUInt16(Math.Floor(myUshortPrompt / Math.Pow(10, 3) % 10));
                    ushort hundreds = Convert.ToUInt16(Math.Floor(myUshortPrompt / Math.Pow (10,2) % 10));
                    ushort decimals = Convert.ToUInt16(Math.Floor(myUshortPrompt / Math.Pow (10, 1) % 10));
                    ushort digit = Convert.ToUInt16(Math.Floor(myUshortPrompt / Math.Pow(10, 0) % 10));
                    ushort sum = (ushort)(thousands + hundreds + decimals + digit);
                    Console.WriteLine("Sum of digits: " + sum);
                    Console.WriteLine("Your number reversed: {0}{1}{2}{3}", digit, decimals, hundreds, thousands);
                    Console.WriteLine("Last digit in front: {0}{3}{2}{1}", digit, decimals, hundreds, thousands);
                    Console.WriteLine("Second and third digits exchanged: {3}{1}{2}{0}", digit, decimals, hundreds, thousands);
                }
                else
                {
                    Console.WriteLine("Wrong data entered, please try again.");
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("You caused exception: System.OverflowException!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You caused exception: System.FormatException!");
            }
           
        }
    }