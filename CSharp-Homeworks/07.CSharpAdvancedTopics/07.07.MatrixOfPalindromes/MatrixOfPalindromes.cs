/* Problem 7.	Matrix of Palindromes
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
Input	Output
3 6	    aaa aba aca	ada aea afa
        bbb bcb bdb	beb bfb bgb
        ccc cec cdc	cfc cgc chc */

using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int r = int.Parse(inputArray[0]);
            int c = int.Parse(inputArray[1]);
            string[,] matrix = new string[r, c];

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
                }
            }
            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}