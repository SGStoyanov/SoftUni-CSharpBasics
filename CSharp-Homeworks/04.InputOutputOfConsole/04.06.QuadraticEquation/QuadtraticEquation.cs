/*Problem 6.	Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax^2 + bx + c = 0 and solves it 
(prints its real roots). */

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a: ");
            string a = Console.ReadLine();
            double aDouble;
            if (!double.TryParse(a, out aDouble))
            {
                Console.WriteLine("Wrong data for coefficient \"a\"!");
            }
            Console.Write("b: ");
            string b = Console.ReadLine();
            double bDouble;
            if (!double.TryParse(b, out bDouble))
            {
                Console.WriteLine("Wrong data for coefficient \"b\"!");
            }
            Console.Write("c: ");
            string c = Console.ReadLine();
            double cDouble;
            if (!double.TryParse(c, out cDouble))
            {
                Console.WriteLine("Wrong data for coefficient \"c\"!");
            }
            if (aDouble != 0)    // Coefficient "a" can't be 0
            {
                double discriminant = (bDouble * bDouble) - (4*aDouble*cDouble);
                if (discriminant > 0)
                {
                    double x1 = ((-bDouble - Math.Sqrt(discriminant)) / (2 * aDouble));
                    double x2 = ((-bDouble + Math.Sqrt(discriminant)) / (2 * aDouble));
                    Console.WriteLine("x1: " + x1);
                    Console.WriteLine("x2: " + x2);
                }
                else if (discriminant == 0)
                {
                    double x1 = (-1 * bDouble) / (2 * aDouble);
                    double x2 = x1;
                    Console.WriteLine("x1: " + x1);
                    Console.WriteLine("x2: " + x2);
                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("There are no real roots. The discriminant is smaller than 0.");
                }
            }
        }
    }