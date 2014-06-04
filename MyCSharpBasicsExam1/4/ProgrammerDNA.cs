using System;


public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n + 1, 2 * n];

        int curRow = n;
        int curCol = 0;

        while (curRow > 0)
        {
            matrix[curRow, curCol] = 1;
            curRow--;
            curCol++;
        }

        while (curCol < 2 * n)
        {
            matrix[curRow, curCol] = 1;
            curCol++;
        }

        curCol--;

        while (curRow < n + 1)
        {
            matrix[curRow, curCol] = 1;
            curRow++;
        }

        curRow--;

        while (curCol > 0)
        {
            matrix[curRow, curCol] = 1;
            curCol--;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
