/*Problem 5.	Formatting Numbers
Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and 
prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number 
a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded 
with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the 
number c should be printed with 3 digits after the decimal point, left aligned. */

using System;

    class FormattingNums
    {
        static void Main()
        {
            Console.Write("Integer: ");
            string promptInt = Console.ReadLine();
            int myInt;
            if (!(int.TryParse(promptInt, out myInt) && myInt <= 500 && myInt >=0))
            {
                Console.WriteLine("Wrong data for the integer");
            }
            Console.Write("Floating-point b: ");
            string promptFloatB = Console.ReadLine();
            float floatB;
            if (!(float.TryParse(promptFloatB, out floatB)))
	        {
                Console.WriteLine("Wrong data for float b");
	        }
            Console.Write("Floating-point c: ");
            string promptFloatC = Console.ReadLine();
            float floatC;
            if (!(float.TryParse(promptFloatC, out floatC)))
            {
                Console.WriteLine("Wrong data for float c");
            }
            Console.Write("|{0,-10:X} ", myInt);
            Console.Write("|" + (Convert.ToString(myInt, 2)).PadLeft(10,'0') + "|");
            Console.Write("{0,10:0.00}|{1,-10:0.000} | \n", floatB, floatC);
        }
    }