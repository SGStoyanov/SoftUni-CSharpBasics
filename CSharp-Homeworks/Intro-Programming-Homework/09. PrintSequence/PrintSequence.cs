//Problem 9: Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;
class PrintSequence
{
    static void Main()
    {
        int a = 2;
        int b = -3;

        for (int i = 0; i < 5; i++)  
        {
            Console.Write("{0} {1} ", a, b);
            a = a + 2;
            b = b - 2;
        }
    }
}