using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicCarNumbers
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());

        char[] symbols = {'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X'};
        char[] symbols2 = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        //int[,] numbers = new int[4,9999];
        int[] numbers = new int[9999];

        char charEl = new char();
        int intEl = new int();
        int result = 0;
        int counter = 0;

        while (result == weight)
        {
            for (int j = 0; j < 9999; j++) // 4 integers symbols
            {
                switch (numbers[j])
                {
                    case 0:
                        charEl = '0';
                        break;
                    case 1:
                        charEl = '1';
                        break;
                    case 2:
                        charEl = '2';
                        break;
                    case 3:
                        charEl = '3';
                        break;
                    case 4:
                        charEl = '4';
                        break;
                    case 5:
                        charEl = '5';
                        break;
                    case 6:
                        charEl = '6';
                        break;
                    case 7:
                        charEl = '7';
                        break;
                    case 8:
                        charEl = '8';
                        break;
                    case 9:
                        charEl = '9';
                        break;
                    default:
                        break;
                }
                result = result + 30 + 10 + numbers[j];               
            }

            for (int i = 0; i < 9; i++)
            {
                switch (symbols[i])
                {
                    case 'A':
                        intEl = 10;
                        break;
                    case 'B':
                        intEl = 20;
                        break;
                    case 'C':
                        intEl = 30;
                        break;
                    case 'E':
                        intEl = 50;
                        break;
                    case 'H':
                        intEl = 80;
                        break;
                    case 'K':
                        intEl = 110;
                        break;
                    case 'M':
                        intEl = 130;
                        break;
                    case 'P':
                        intEl = 160;
                        break;
                    case 'T':
                        intEl = 200;
                        break;
                    case 'X':
                        intEl = 240;
                        break;
                    default:
                        break;
                }
                result = result + symbols[i];
            }
                for (int i = 0; i < 9; i++)
                {
                    switch (symbols2[i])
                    {
                        case 'A':
                            intEl = 10;
                            break;
                        case 'B':
                            intEl = 20;
                            break;
                        case 'C':
                            intEl = 30;
                            break;
                        case 'E':
                            intEl = 50;
                            break;
                        case 'H':
                            intEl = 80;
                            break;
                        case 'K':
                            intEl = 110;
                            break;
                        case 'M':
                            intEl = 130;
                            break;
                        case 'P':
                            intEl = 160;
                            break;
                        case 'T':
                            intEl = 200;
                            break;
                        case 'X':
                            intEl = 240;
                            break;
                        default:
                            break;
                    }
                    result = result + symbols2[i];
                }
                counter++;
        }
        Console.WriteLine(counter);
    }
}