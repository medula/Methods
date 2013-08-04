//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".
using System;

class ReturnDigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Input a number: ");
        int number = int.Parse(Console.ReadLine());
        int digit = (number % 10);
        Console.WriteLine("Last digit of number input is {0}.", takeDigit(digit));
    }
    static string takeDigit(int digit)
    {
        string word = " ";
        switch (digit)
        {
            case 1:
                word = "one";
                break;
            case 2:
                word = "two";
                break;
            case 3:
                word = "three";
                break;
            case 4:
                word = "four";
                break;
            case 5:
                word = "five";
                break;
            case 6:
                word = "six";
                break;
            case 7:
                word = "seven";
                break;
            case 8:
                word = "eight";
                break;
            case 9:
                word = "nine";
                break;
            case 0:
                word = "zero";
                break;
            default:
                Console.WriteLine("Invalid digit");
                return null;
        }
        return word;
    }
}

