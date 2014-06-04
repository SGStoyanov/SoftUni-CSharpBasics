/*Problem 10.	Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the 
 * rectangle R(top=1, left=-1, width=6, height=2). */

using System;
using System.Globalization;

    class PointPosCircleRectangle
    {
        static void Main()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone(); //Providing compatibility for the decimal delimiter
            ci.NumberFormat.CurrencyDecimalSeparator = ".";

            Console.Write("x: ");
            float x = float.Parse(Console.ReadLine(), NumberStyles.Any, ci);
            Console.Write("y: ");
            float y = float.Parse(Console.ReadLine(), NumberStyles.Any, ci);
            float xCenter = Math.Abs(x - 1);
            float yCenter = Math.Abs(y - 1);
            float radiusResult = (float)Math.Sqrt(Math.Pow(xCenter,2) + Math.Pow(yCenter,2));
            bool inCircle = false;
            bool inRectangle = false;
            
            if (radiusResult <= 1.5)
            {
                inCircle = true;
            }
            if (x >= -1 && x <= 5 && y >= -1 && y <= 1)
            {
                inRectangle = true;
            }
           
            if (inCircle && !inRectangle)
            {
                bool finalResult = true;
                Console.WriteLine("Inside K & outside of R: " + finalResult);
            }
            else if (!inCircle && inRectangle)
            {
                bool finalResult = false;
                Console.WriteLine("Inside K & outside of R: " + finalResult);
            }
            else if (inCircle && inRectangle)
            {
                bool finalResult = false;
                Console.WriteLine("Inside K & outside of R: " + finalResult);
            }
            else if (!inCircle && !inRectangle)
            {
                bool finalResult = false;
                Console.WriteLine("Inside K & outside of R: " + finalResult);
            }
        }
    }