﻿//Problem 5.	Unicode Value
//Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it. Hint: first, 
//use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.

using System;
class UnicodeVal
{
    static void Main()
    {
        char myChar = '\u0048';
        Console.WriteLine("The heximal Unicode character \'\\0048\' (equal to 72 in decimal) is: " + myChar);
    }
}