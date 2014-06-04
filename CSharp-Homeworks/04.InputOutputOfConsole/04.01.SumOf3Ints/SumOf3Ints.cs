//Problem 1.	Sum of 3 Integers
//Write a program that reads 3 integer numbers from the console and prints their sum. 

using System;

    class Sumof3Ints
    {
        static void Main()
        {
            Console.Write("a: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum: " + (num1 + num2 + num3));
        }
    }