/*Problem 7.	Point in a Circle
Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). */

using System;
using System.Globalization; //Needed for the Cultureinfo subclass

    class PointInCircle
    {
        static void Main()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone(); //Providing compatibility for the decimal delimiter
            ci.NumberFormat.CurrencyDecimalSeparator = ".";                   // and it will be "."
                
            Console.Write("x: " );
            string xPrompt = Console.ReadLine();
            float x = float.Parse(xPrompt, NumberStyles.Any, ci);
            Console.Write("y: ");
            string yPrompt = Console.ReadLine();
            float y = float.Parse(yPrompt, NumberStyles.Any, ci);
            float radiusResult = (float)Math.Sqrt((float)(Math.Pow(x,2) + Math.Pow(y,2)));
            Console.WriteLine("Radius of your point: " + radiusResult);

            if (radiusResult <= 2)
            {
                Console.WriteLine("The point with coordinates ({0} {1}) is inside the circle.", x, y);
            }
            else
            {
                Console.WriteLine("The point with coordinates ({0} {1}) is outside the circle.", x, y);
            }
        }
    }