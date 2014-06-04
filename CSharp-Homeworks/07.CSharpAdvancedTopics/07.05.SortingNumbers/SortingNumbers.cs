// Problem 5.	Sorting Numbers
// Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 

using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());  // getting array elements' value
        }
        Array.Sort(myArray); // method which sorts the array elements by their value
        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
    }
}