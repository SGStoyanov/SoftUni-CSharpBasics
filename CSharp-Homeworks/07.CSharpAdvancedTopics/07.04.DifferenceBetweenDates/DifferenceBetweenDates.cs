// Problem 4.	Difference between Dates
// Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 

using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        while (true)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            int days = (secondDate - firstDate).Days;
            Console.WriteLine("Days between: " + days);   
        }
    }
}