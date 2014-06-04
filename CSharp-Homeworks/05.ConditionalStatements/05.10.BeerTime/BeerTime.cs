/* Problem 10. Beer Time  
A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” 
according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to 
parse dates and times. */

using System;
using System.Globalization;

class Beertime 
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");

        Console.WriteLine("Enter time in format hh:mm tt");
        string yourTime = Console.ReadLine();
        DateTime yourTimeConv;
        DateTime startTime = DateTime.Parse("01:00 PM");
        DateTime endTime = DateTime.Parse("03:00 AM");

        if (DateTime.TryParseExact(yourTime, "h:mm tt", enUS, DateTimeStyles.None, out yourTimeConv))
        {
            if (yourTimeConv >= startTime || yourTimeConv < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}