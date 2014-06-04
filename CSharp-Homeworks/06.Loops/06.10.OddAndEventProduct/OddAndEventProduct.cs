/* Problem 10.	Odd and Even Product
You are given n integers (given in a single line, separated by a space). Write a program that checks whether the 
product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so 
the first element is odd, the second is even, etc. */

using System;

class OddAndEventProduct
{
    static void Main()
    {
        while (true)
        {
            Console.Write("n: ");
            string prompt = Console.ReadLine();
            string[] splittedNumbers = prompt.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < splittedNumbers.Length; i++)
            {
                int tempNumber = int.Parse(splittedNumbers[i]);
                bool isEven = (i + 1) % 2 == 0;
                bool isOdd = (i + 1) % 2 != 0;

                if (isEven)
                {
                    evenProduct *= tempNumber;
                }
                else if (isOdd)
                {
                    oddProduct *= tempNumber;
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("The product is: {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", oddProduct);
                Console.WriteLine("even_product = {0}", evenProduct);
            }
        }
    }
}