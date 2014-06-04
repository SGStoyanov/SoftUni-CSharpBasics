/*Problem 10.	Exchange Variable Values
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. 
Print the variable values before and after the exchange.*/

using System;
using System.Text;
    class ExchVarVals
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c = a;

            Console.WriteLine("Before the exchange: a = {0}, b = {1}.", a, b);
            a = b;
            b = c;
            Console.WriteLine("After the exchange: a = {0}, b = {1}.", a, b);
        }
    }