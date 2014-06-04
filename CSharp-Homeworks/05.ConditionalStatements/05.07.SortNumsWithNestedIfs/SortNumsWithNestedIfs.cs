// Problem 7.	Sort 3 Numbers with Nested Ifs
// Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. 
// Don’t use arrays and the built-in sorting functionality. 

using System;

class SortNumsWithNestedIfs
{
    static void Main()
    {
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());
        float num3 = float.Parse(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3) // num1 >= num2 >= num3 || num1 >= num3 >= num2 scenario
        {
            if (num2 >= num3)
            {
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }
            else if (num3 >= num2)
            {
                Console.WriteLine("{0} {1} {2}", num1, num3, num2);
            } 
        }
        else if (num2 >= num1 && num2 >= num3) // num2 >= num1 >= num3 || num2 >= num3 >= num1 scenario
        {
            if (num1 >= num3)
            {
                Console.WriteLine("{0} {1} {2}", num2, num1, num3);
            }
            else if (num3 >= num1)
            {
                Console.WriteLine("{0} {1} {2}", num2, num3, num1);
            }
        }
        else if (num3 >= num1 && num3 >= num2) // num3 >= num1 >= num2 || num3 >= num2 >= num1 scenario
        {
            if (num1 >= num2)
            {
                Console.WriteLine("{0} {1} {2}", num3, num1, num2);
            }
            else if (num2 >= num1)
            {
                Console.WriteLine("{0} {1} {2}", num3, num2, num1);
            }
        }
        else
        {
            Console.WriteLine("Wrong data!");
        }
    }
}