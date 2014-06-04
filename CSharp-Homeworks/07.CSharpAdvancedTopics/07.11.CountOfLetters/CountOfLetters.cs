/* Problem 11.	Count of Letters
Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
The letters should be listed in alphabetical order. */

using System;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main()
    {
        string charList = Console.ReadLine();
        string[] allLetters = charList.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<char> lettersList = new List<char>();

        for (int i = 0; i < allLetters.Length; i++)
        {
            lettersList.Add(Convert.ToChar(allLetters[i]));
        }
        lettersList.Sort();

        int counter = 1;
        for (int i = 1; i < lettersList.Count; i++)
        {
            if (lettersList[i] == lettersList[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", lettersList[i - 1], counter);
                counter = 1;
            } 
            if (i == lettersList.Count - 1) // Checking the last element of the List
            {
                Console.WriteLine("{0} -> {1}", lettersList[i], counter);
            }
        }
    }
}