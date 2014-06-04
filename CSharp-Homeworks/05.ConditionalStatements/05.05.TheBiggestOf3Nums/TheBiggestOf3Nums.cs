// Problem 5.	The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers. 

using System;

class TheBiggestOf3Nums
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers (each on a separate line): ");
        float numA = float.Parse(Console.ReadLine());
        float numB = float.Parse(Console.ReadLine());
        float numC = float.Parse(Console.ReadLine());

        if ((numA > numB) && (numA > numC))
        {
            Console.WriteLine("Biggest: " + numA);
        }
        else if ((numB > numA) && (numB > numC))
        {
            Console.WriteLine("Biggest: " + numB);
        }
        else if ((numC > numA) && (numC > numB))
        {
            Console.WriteLine("Biggest: " + numC);
        }
    }
}