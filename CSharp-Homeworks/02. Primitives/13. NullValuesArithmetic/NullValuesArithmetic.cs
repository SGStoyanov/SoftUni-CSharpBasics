/* Problem 13. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. 
Try to add some number or the null literal to these variables and print the result.*/

using System;
    class NullValyesArithmetic
    {
        static void Main()
        {
            int? nullInt = null;
            double? nullDouble = null;
            nullInt = 5;
            nullDouble = 17;

            Console.WriteLine("{0}\n{1}", nullInt, nullDouble);
            Console.WriteLine(nullInt + null);
        }
    }