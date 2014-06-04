/* Problem 15.	Extract URLs from Text
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com */

using System;
using System.Linq;

class ExtractURLsFromText
{
    static void Main()
    {
        string text = @"The site nakov.com can be access from http://nakov.com or www.nakov.com. 
                        It has subdomains like mail.nakov.com and svetlin.nakov.com. 
                        Please check http://blog.nakov.com for more information.";
        string[] textArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < textArr.Length; i++)
        {
            if (textArr[i].StartsWith("http://") || textArr[i].StartsWith("www"))
            {
                Console.WriteLine(textArr[i]);
            }
        }
    }
}