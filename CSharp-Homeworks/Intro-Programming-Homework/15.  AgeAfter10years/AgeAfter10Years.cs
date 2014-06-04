//Problem 15.	* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;
    class AgeAfter10Years
    {
        static void Main()
        {
                Console.WriteLine("Enter your birthday date in format day/month/year: "); // Prompt
                string birthday = Console.ReadLine(); // Get string from user
                try
                {
                    DateTime dt = DateTime.Parse(birthday); // Converting to DateTime
                    DateTime now = DateTime.Today;
                    int age = now.Year - dt.Year;
                    Console.WriteLine("Your current age is: " + age + ". After 10 years you will be on: " + (age + 10) + ".");
                }
                catch (System.ArgumentNullException) 
                {
                    Console.WriteLine("You triggered \"System.ArgumentNullException\". Please enter a date!");
                    Console.Beep();
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You triggered \"System.FormatException\". Please enter a correct date!");
                    Console.Beep();
                }
        }
    }