/* Problem 16
* Write a program that exchanges bits {p, p+1, …, p+k-1}
* with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
* The first and the second sequence of bits may not overlap
*/

using System;

class AdvancedBitExchange
{
    static void Main()
    {
        uint number = 0;
        try
        {
            Console.Write("Number: ");
            number = uint.Parse(Console.ReadLine());
            Console.WriteLine(number + " = " +(Convert.ToString(number, 2)));
        }
        catch (OverflowException)
        {
            Console.WriteLine("Out of range"); //checks if the number is too big to fit in a uint type
        }
        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("q: ");
        int k = int.Parse(Console.ReadLine());
        if (Math.Abs(Math.Abs(q) - Math.Abs(p)) < k) //checks if overlapping
        {
            Console.WriteLine("Overlapping");
        }
        else if ((p + k > 32) || (q + k > 32) ||
                 (p < 0) || (q < 0))
        {
            Console.WriteLine("Out of range");
        }
        else
        {
            uint mask = Convert.ToUInt32(new string('1', k), 2); 
            uint pBits = ((mask << p) & number) >> p;
            uint qBits = ((mask << q) & number) >> q;
            number = ~(mask << p) & number;
            number = ~(mask << q) & number;
            number = (pBits << q) | number;
            number = (qBits << p) | number;
            Console.WriteLine("After the bits exchanging:");
            Console.WriteLine(number + " = " + (Convert.ToString(number, 2)));
        }
    }
}