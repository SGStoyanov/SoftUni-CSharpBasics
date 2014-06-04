using System;
using System.Text;

class DivideByTwoNumbers
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Please enter a number: ");
        string prompt = Console.ReadLine();
        int num = Convert.ToInt32(prompt);

        Console.WriteLine();
        Console.Write("n".PadRight(15));
        Console.Write("Divided by 7 and 5? ".PadRight(15));
        Console.WriteLine();
        
        bool result = num % 7 == 0 && num % 5 == 0;
        if (result)
        {
            Console.Write(num.ToString().PadRight(15));
            Console.Write(Convert.ToString(result).PadRight(15));
        }
        else
        {
            Console.Write(num.ToString().PadRight(15));
            Console.Write(Convert.ToString(result).PadRight(15));
        }
        Console.WriteLine();
    }
}