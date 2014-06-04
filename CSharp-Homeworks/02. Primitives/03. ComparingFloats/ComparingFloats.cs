//Problem 3.	Comparing Floats
//Write a program that safely compares floating-point numbers with precision eps = 0.000001. Note that we cannot directly 
//compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, 
//we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

using System;
    class ComparingFloats
    {
        static void Main()
        {
            float myFloat =  3.43845313f;
            float myFloat2 = 3.43845212f;
            float diff = myFloat - myFloat2;

            Console.WriteLine(diff);

            if (diff < 0.000001) // Check if the required precision is reached
            {
                Console.WriteLine("The numbers {0} and {1} are equal.", myFloat, myFloat2);
            }
            else
            {
                Console.WriteLine("The numbers {0} and {1} are NOT equal.", myFloat, myFloat2);
            }
        }
    }