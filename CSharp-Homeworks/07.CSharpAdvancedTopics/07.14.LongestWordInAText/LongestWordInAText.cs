// Problem 14.	Longest Word in a Text
// Write a program to find the longest word in a text. 

using System;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var sorted = inputArray.OrderBy(n => n.Length);
        var longest = sorted.LastOrDefault();

        if (longest.EndsWith("."))
        {
            longest = longest.Substring(0, longest.Length - 1); // removing the "." from the string
        }
        Console.WriteLine(longest);
    }
}