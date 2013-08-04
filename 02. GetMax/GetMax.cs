//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
using System;

class GetMaxSolution
{
    static void Main()
    {
        int inputOne = int.Parse(Console.ReadLine());
        int inputSecond = int.Parse(Console.ReadLine());
        int inputThird = int.Parse(Console.ReadLine());
        int maxNumber = GetMax(GetMax(inputOne, inputSecond), inputThird);
        Console.WriteLine("The biggest of three numbers entered is {0}.", maxNumber);
    }
    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = 0;
        if (firstNumber > secondNumber)
        {
            maxNumber = firstNumber;
        }
        else
        {
            maxNumber = secondNumber;
        }
        return maxNumber;
    }
}





