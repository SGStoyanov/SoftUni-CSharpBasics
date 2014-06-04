using System;
using System.Text;

    class MoonGravity
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Please enter your weight: ");
            string prompt = Console.ReadLine();
            int weight = Convert.ToInt32(prompt);
            float moonWeight = weight * 0.17f;

            Console.WriteLine(); 
            Console.Write("Weight".PadRight(15));
            Console.Write("Weight on the Moon".PadRight(15));

            Console.WriteLine();
            Console.Write(weight.ToString().PadRight(15));
            Console.Write(moonWeight.ToString().PadRight(15));
            Console.WriteLine();
            
        }
    }