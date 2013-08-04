//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class AddTwoIntegers
{
    static void Main()
    {
        string integerOne = Console.ReadLine();
        string integerTwo = Console.ReadLine();
        int[] integerOneDigits = new int[integerOne.Length];
        int[] integerTwoDigits = new int[integerTwo.Length];
        for (int digit = 0; digit < integerOneDigits.Length; digit++)
        {
            integerOneDigits[digit] = int.Parse(Convert.ToString(integerOne[integerOne.Length - 1 - digit]));
        }
        for (int digit = 0; digit < integerTwo.Length; digit++)
        {
            integerTwoDigits[digit] = int.Parse(Convert.ToString(integerTwo[integerTwo.Length - 1 - digit]));
        }
        var newArray = AddNumbers(integerOneDigits, integerTwoDigits);
        foreach (var member in newArray)
        {
            Console.Write(member);
        }
        Console.WriteLine();
    }
    static List<int> AddNumbers(int[] integerFirstDigits, int[] integerSecondDigits)
    {
        int minLength = Math.Min(integerFirstDigits.Length, integerSecondDigits.Length);
        int maxLength = Math.Max(integerFirstDigits.Length, integerSecondDigits.Length);
        List<int> reversedResult = new List<int>();
        int carry = 0;
        for (int index = 0; index < minLength; index++)
        {
            int sum = integerFirstDigits[index] + integerSecondDigits[index] + carry;
            if (sum < 10)
            {
                reversedResult.Add(sum);
                carry = 0;
            }
            if (sum >= 10)
            {
                reversedResult.Add(sum % 10);
                carry = sum / 10;
            }
            if (index == integerFirstDigits.Length - 1)
            {
                for (int i = minLength; i < integerSecondDigits.Length; i++)
                {
                    int subSum2 = integerSecondDigits[i] + carry;
                    if (subSum2 < 10)
                    {
                        reversedResult.Add(subSum2);
                        carry = 0;
                    }
                    if (subSum2 >= 10)
                    {
                        reversedResult.Add(subSum2 % 10);
                        carry = sum / 10;
                    }
                }
            }
            if (index == integerSecondDigits.Length - 1)
            {
                for (int i = minLength; i < integerFirstDigits.Length; i++)
                {
                    int subSum1 = integerFirstDigits[i] + carry;
                    if (subSum1 < 10)
                    {
                        reversedResult.Add(subSum1);
                        carry = 0;
                    }
                    if (subSum1 >= 10)
                    {
                        reversedResult.Add(subSum1 % 10);
                        carry = sum / 10;
                    }
                }
            }
        }
        if (carry > 0)
        {
            reversedResult.Add(carry);
        }
        reversedResult.Reverse();
        return reversedResult;
    }
}

