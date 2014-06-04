/* Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
If the variable is int or double, the program increases it by one. If the variable is a string, the program appends 
"*" at the end. Print the result at the console. Use switch statement. */

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int\n2 --> double\n3 --> string");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int yourInt = int.Parse(Console.ReadLine());
                Console.WriteLine(yourInt + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double yourDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(yourDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string yourString = Console.ReadLine();
                Console.WriteLine(yourString + "*");
                break;
            default:
                Console.WriteLine("Wrong choice.");
                break;
        }
    }
}