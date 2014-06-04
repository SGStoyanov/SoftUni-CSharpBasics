// Problem 2.	Float or Double?
//Which of the following values can be assigned to a variable of type float and which to a variable of type 
//double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and 
//print them to ensure no precision is lost.

using System;
    class FloatOrDouble
    {
        static void Main()
        {
            double myDouble = 34.567839023d;
            float myFloat = 12.345f;
            double myDouble2 = 8923.1234857d;
            float myFloat2 = 3456.091f;

            Console.WriteLine("A double: " + myDouble);
            Console.WriteLine("А float: " + myFloat);
            Console.WriteLine("A double: " + myDouble2);
            Console.WriteLine("A float: " + myFloat2);
        }
    }