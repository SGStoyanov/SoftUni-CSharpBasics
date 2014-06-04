using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers (each on a separate line): ");
        double doubleA = double.Parse(Console.ReadLine());
        double doubleB = double.Parse(Console.ReadLine());
        double doubleC = double.Parse(Console.ReadLine());
        double doubleD = double.Parse(Console.ReadLine());
        double doubleE = double.Parse(Console.ReadLine());

        bool resultA = (doubleA >= doubleB) && (doubleA >= doubleC) && (doubleA >= doubleD) && (doubleA >= doubleE);
        bool resultB = (doubleB >= doubleA) && (doubleB >= doubleC) && (doubleB >= doubleD) && (doubleB >= doubleE);
        bool resultC = (doubleC >= doubleA) && (doubleC >= doubleB) && (doubleC >= doubleD) && (doubleC >= doubleE);
        bool resultD = (doubleD >= doubleA) && (doubleD >= doubleB) && (doubleD >= doubleC) && (doubleD >= doubleE);
        bool resultE = (doubleE >= doubleA) && (doubleE >= doubleB) && (doubleE >= doubleC) && (doubleE >= doubleD);

        if (resultA)
        {
            Console.WriteLine("Biggest: " + doubleA);
        }
        else if (resultB)
        {
            Console.WriteLine("Biggest: " + doubleB);
        }
        else if (resultC)
        {
            Console.WriteLine("Biggest: " + doubleC);
        }
        else if (resultD)
        {
            Console.WriteLine("Biggest: " + doubleD);
        }
        else if (resultE)
        {
            Console.WriteLine("Biggest: " + doubleE);
        }
    }
}