//Problem 4. Write a program that gets two numbers from the console and prints the greater of them. Try to implement 
//this without if statements. 

using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("a: ");
            string a = Console.ReadLine();
            float aConv = float.Parse(a);
            Console.Write("b: ");
            string b = Console.ReadLine();
            float bConv = float.Parse(b);
            double desiredNum = Math.Max(aConv, bConv);
            Console.WriteLine("The bigger number is: " + desiredNum);
        }
    }