using System;
using System.Globalization;

    class Trapezoids
    {
        static void Main()
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone(); //Providing compatibility for the decimal delimiter
            ci.NumberFormat.CurrencyDecimalSeparator = ".";                   // and it will be "."
            
            Console.Write("a: ");
            float a = float.Parse(Console.ReadLine(), NumberStyles.Any, ci);
            Console.Write("b: ");
            float b = float.Parse(Console.ReadLine(), NumberStyles.Any, ci);
            Console.Write("h: ");
            float h = float.Parse(Console.ReadLine(), NumberStyles.Any, ci);

            if ((a > 0) && (b > 0) && (h > 0))
            {
                float area = ((a + b) / 2) * h;
                Console.WriteLine("Area: " + area);
            }
            else
            {
                Console.WriteLine("Wrong data!");
            }
        }
    }