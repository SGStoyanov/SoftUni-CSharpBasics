using System;

class CalculateFactorials
{
    static void Main()
    {
        Console.Write("n: ");
        double doubleN = double.Parse(Console.ReadLine());
        Console.Write("x: ");
        double doubleX = double.Parse(Console.ReadLine());
        double factN = 1;
        double intX = 1;
        double sum = 0;

        for (int i = 1; i <= doubleN; i++)
        {
            intX *= doubleX;
            factN *= i;
            sum += factN/intX;
        }
        Console.Write("Sum: {0:0.00000}\n", sum+1);
    }
}