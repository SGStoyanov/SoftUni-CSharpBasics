//Problem 14.	* Current Date and Time
//Create a console application that prints the current date and time. Find in Internet how.

using System;
    class CurrentDateTime
    {
        static void Main()
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("The current date and time is: " + dateNow);
        }
    }