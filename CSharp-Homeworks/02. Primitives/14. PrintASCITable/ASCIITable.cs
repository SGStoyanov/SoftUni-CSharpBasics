/*Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to 
prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters 
have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may 
need to use for-loops (learn in Internet how).*/

using System;
using System.Text;
class ASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.Write("Hex".PadRight(10));
        Console.WriteLine();

        int min = 0;
        int max = 255;
        for (int i = min; i <= max; i++)
        {
            // Get ascii character.
            char c = (char)i;
            // Get display string.
            string display = string.Empty;
            if (char.IsWhiteSpace(c))
            {
                display = c.ToString();
                switch (c)
                {
                    case '\t':
                        display = "\\t";
                        break;
                    case ' ':
                        display = "space";
                        break;
                    case '\n':
                        display = "\\n";
                        break;
                    case '\r':
                        display = "\\r";
                        break;
                    case '\v':
                        display = "\\v";
                        break;
                    case '\f':
                        display = "\\f";
                        break;
                }
            }
            else if (char.IsControl(c))
            {
                display = "control";
            }
            else
            {
                display = c.ToString();
            }
            // Write table row.
            Console.Write(i.ToString().PadRight(10));
            Console.Write(display.PadRight(10));
            Console.Write(i.ToString("X2"));
            Console.WriteLine();
        }
    }
}