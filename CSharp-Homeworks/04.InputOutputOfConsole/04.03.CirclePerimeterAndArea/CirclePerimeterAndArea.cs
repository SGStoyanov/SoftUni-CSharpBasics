//Problem 3.	Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits 
//after the decimal point. Examples:

using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Radius r: ");
            string radius = Console.ReadLine();
            double radiusConv = double.Parse(radius);
            double area = Math.PI*Math.Pow(radiusConv, 2);
            double perimeter = 2 * Math.PI * radiusConv;
            Console.WriteLine("Area: {0:0.00} \nPerimeter: {1:0.00}", area, perimeter);
        }
    }