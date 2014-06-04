/* Problem 10.	Join Lists
Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, 
and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are 
given as integers, separated by a space, each list at a separate line. */

using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        while (true)
        {
            string line1 = Console.ReadLine();
            string[] strArrLine1 = line1.Split(' '); // using string[] as the Split method doesn't exist in int[] class
            string line2 = Console.ReadLine();
            string[] strArrLine2 = line2.Split(' ');
            
            int[] intArrLine1 = strArrLine1.Select(int.Parse).ToArray(); // converting string[] to int[]
            int[] intArrLine2 = strArrLine2.Select(int.Parse).ToArray();

            IEnumerable<int> myUnion = intArrLine1.Union(intArrLine2); // uniting both int[] without the repeated values
            var sortedUnion = myUnion.OrderBy(i => i); // sorting the elements by their (integer) value

            foreach (var item in sortedUnion) // iterating over the elements of the final sorted list
            {
                Console.Write(item + " "); // printing the elements of the list
            }
            Console.WriteLine();
        }
    }
}