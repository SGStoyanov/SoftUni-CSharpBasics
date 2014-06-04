using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char start = char.Parse(Console.ReadLine());
        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        int counter1 = 3;
        int counter2 = 1;

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < 7; cols++)
            {
                while (cols < counter1)
                {
                    Console.Write('.');  
                }
                if (cols < counter1)
                {
                      
                }
                
            }
            Console.WriteLine();
        }
    }

}