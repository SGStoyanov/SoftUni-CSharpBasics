//Problem 1.	Exchange If Greater
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is 
//greater than the second one. As a result print the values a and b, separated by a space. 

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("a: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("b: ");
        float num2 = float.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            float temp = num1;
            num1 = num2;
            num2 = temp;
        }
        Console.WriteLine("{0} {1}", num1, num2);
    }
}