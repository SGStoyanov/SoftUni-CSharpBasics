/* Problem 16.	* Counting a Word in a Text
Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. 
The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. 
Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. 
A word is a sequence of letters separated by punctuation or start / end of text. */

using System;
using System.Collections.Generic;
using System.Linq;

class CountingAWordInAText
{
    static void Main()
    {
        while (true)
        {
            string keyword = Console.ReadLine();
            string someText = Console.ReadLine();

            int result = CompareWords(keyword, someText);
            Console.WriteLine(result);     
        }
    }

    static int CompareWords (string inputWord, string inputText)
    {
        string[] textArr = inputText.Split(new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')'}, 
                                           StringSplitOptions.None);
        int counter = 0;

        for (int i = 0; i < textArr.Length; i++)
        {
            if (string.Equals(textArr[i], inputWord, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
        }
        return counter;
    }
}