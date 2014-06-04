/* Problem 9.	Remove Names
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
The input and output lists are given as words, separated by a space, each list at a separate line. */

using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        while (true)
        {
            string namesLine1 = Console.ReadLine(); // getting the inputs
            string namesLine2 = Console.ReadLine();
            string[] arrayLine1 = namesLine1.Split(' '); // static arrays
            string[] arrayLine2 = namesLine2.Split(' ');
            List<string> listLine1 = new List<string>(); // a dynamic list as its values will be manipulated

            for (int i = 0; i < arrayLine1.Length; i++) // transferring the array's values into the List
            {
                listLine1.Add(arrayLine1[i]);
            }

            foreach (var item in arrayLine1) // iterating over the elements of the static array lenght
            {
                for (int i = 0; i < arrayLine2.Length; i++) // iterating over array Line 2
                {
                    if (item == arrayLine2[i]) // comparing the elements of Line 1 with each of the elements of Line 2
                    {
                        listLine1.Remove(item); // if found the element in Line 1 is removed
                    }
                }
            }

            foreach (var item in listLine1) // printing the result
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();   
        }
    }
}