/* Problem 12.	Count of Names
Write a program that reads a list of names and prints for each name how many times it appears in the list. 
The names should be listed in alphabetical order. Use the input and output format from the examples below. */

using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        string names = Console.ReadLine();
        string[] namesArray = names.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> namesList = new List<string>();

        for (int i = 0; i < namesArray.Length; i++)
        {
            namesList.Add(namesArray[i]);
        }
        namesList.Sort();

        int counter = 1;

        for (int i = 1; i < namesList.Count; i++)
        {
            if (namesList[i] == namesList[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", namesList[i - 1], counter);
                counter = 1;
            }
            if (i == namesList.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", namesList[i], counter);
            }
        }
    }
}