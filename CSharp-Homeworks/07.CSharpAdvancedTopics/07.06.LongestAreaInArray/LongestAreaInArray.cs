/* Problem 6.	Longest Area in Array
Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings 
 (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). 
 If multiple sequences have the same maximal length, print the leftmost of them. */

using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        string[] strArray = new string[n];

        for (int i = 0; i < n; i++)
        {
            strArray[i] = Console.ReadLine();
        }

        int maxCount = 0;
        string value = null;

        for (int i = 0; i < strArray.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < strArray.Length; j++)
            {
                if (strArray[i] == strArray[j])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        value = strArray[i];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine("\nThe element of maximal sequence is \"{0}\", repeated {1} times", value, maxCount);
    }
}