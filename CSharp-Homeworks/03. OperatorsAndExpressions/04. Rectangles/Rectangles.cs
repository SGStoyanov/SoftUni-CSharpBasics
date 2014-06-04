using System;
using System.Text;

    class Rectangles
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Enter a width: ");
            string width = Console.ReadLine();
            Console.WriteLine("Enter a height: ");
            string height = Console.ReadLine();

            int perimeter = (Convert.ToInt32(width))*2 + (Convert.ToInt32(height))*2;
            int area = (Convert.ToInt32(width)) * (Convert.ToInt32(height));

            Console.Write("Width".PadRight(10)); //Printing rows' titles
            Console.Write("Height".PadRight(10));
            Console.Write("Perimeter".PadRight(15));
            Console.Write("Area".PadRight(10));
            Console.WriteLine();

            Console.Write(width.PadRight(10)); //Printing values
            Console.Write(height.PadRight(10));
            Console.Write(perimeter.ToString().PadRight(15));
            Console.Write(area.ToString().PadRight(10));
            Console.WriteLine();
        }
    }