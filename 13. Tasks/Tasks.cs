//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//	Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;

class Tasks
{
    static void Main()
    {
        Console.WriteLine(" Choose a number for the task :");
        Console.WriteLine("1.   Reverses digits of a number");
        Console.WriteLine("2.   Calculates the average of integers");
        Console.WriteLine("3.   Solve a linear equation a * x + b = 0");
        int taskNumber = int.Parse(Console.ReadLine());
        if (taskNumber == 1)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Number should be non-negative. Thank you!");
                return;
            }
            else
            {
                List<int> reversedNumber = ReverseDigitOfNumber(number);
                Print(reversedNumber);
                Console.WriteLine();
                return;
            }
        }
        else if (taskNumber == 2)
        {
            Console.Write("Enter length of sequence: ");
            int length = int.Parse(Console.ReadLine());
            if (length == 0)
            {
                Console.WriteLine("The sequence should not be empty.");
                return;
            }
            else
            {
                int[] arrayNumbers = new int[length];
                for (int index = 0; index < arrayNumbers.Length; index++)
                {
                    arrayNumbers[index] = int.Parse(Console.ReadLine());
                }
                int averageNumber = AverageOfIntegers(arrayNumbers);
                Console.WriteLine("{0}", averageNumber);
                Console.WriteLine();
                return;
            }
        }
        else
        {
            Console.Write("Enter coefficient a: ");
            int coefA = int.Parse(Console.ReadLine());
            if (coefA == 0)
            {
                Console.WriteLine(" Coefficient 'a' should not be equal to 0");
                return;
            }
            else
            {
                Console.Write("Enter coefficient b: ");
                int coefB = int.Parse(Console.ReadLine());
                float root = LinearEquation(coefA, coefB);
                Console.WriteLine("{0}", root);
            }
        }

        
    }

    private static List<int> ReverseDigitOfNumber(int number)
    {
        List<int> reversedNumber = new List<int>();


        while (number >= 1)
        {
            int digit;
            digit = number % 10;
            reversedNumber.Add(digit);
            number = number / 10;
        }
        return reversedNumber;
    }
    private static void Print(List<int> ReverseDigitOfNumber)
    {
        for (int i = 0; i < ReverseDigitOfNumber.Count; i++)
        {
            Console.Write("{0}", ReverseDigitOfNumber[i]);
        }
    }
    private static int AverageOfIntegers(int[] arrayNumbers)
    {
        int sum = 0;
        for (int index = 0; index < arrayNumbers.Length; index++)
        {
            sum += arrayNumbers[index];
        }
        int average = sum / arrayNumbers.Length;
        return average;
    }
    private static float LinearEquation(float coefA, float coefB)
    {
        float root = -coefB / coefA;
        return root;
    }
}

