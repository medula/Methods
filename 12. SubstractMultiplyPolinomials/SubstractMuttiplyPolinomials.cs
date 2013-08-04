// Extend the program to support also subtraction and multiplication of polynomials.
using System;

class SubstractMuttiplyPolinomials
{
    static void Main()
    {
        int[] arrayFirst = { 4, 5, 0, 6, 7 };
        int[] arraySecond = { 6, 7 };
        int[] arrayResult = SubstractPolinomials(arrayFirst, arraySecond);
        Array.Reverse(arrayResult);
        for (int index = 0; index < arrayResult.Length; index++)
        {
            Console.Write("{0} ", arrayResult[index]);
        }
        Console.WriteLine();
        arrayResult = MultiplyPolinomials(arrayFirst, arraySecond);
        for (int index = 0; index < arrayResult.Length; index++)
        {
            Console.Write("{0} ", arrayResult[index]);
        }
    }

    private static int[] SubstractPolinomials(int[] arrayFirst, int[] arraySecond)
    {
        Array.Reverse(arrayFirst);
        Array.Reverse(arraySecond);
        int arrayResultLength = Math.Max(arrayFirst.Length, arraySecond.Length);
        int minLength = Math.Min(arrayFirst.Length, arraySecond.Length);
        int[] arrayResult = new int[arrayResultLength];
        for (int i = 0; i < minLength; i++)
        {
            arrayResult[i] = arrayFirst[i] -arraySecond[i];
        }
        for (int j = minLength; j < arrayResult.Length; j++)
        {
            if (arrayFirst.Length < arraySecond.Length)
            {
                arrayResult[j] = arraySecond[j];
            }
            else
            {
                arrayResult[j] = arrayFirst[j];
            }
                    }
        return arrayResult;
    }
    private static int[] MultiplyPolinomials(int[] arrayFirst, int[] arraySecond)
    {
        Array.Reverse(arrayFirst);
        Array.Reverse(arraySecond);
        int[] arrayResult = new int[arrayFirst.Length + arraySecond.Length];
        for (int i = 0; i < arrayFirst.Length; i++)
        {
            for (int j = 0; j < arraySecond.Length; j++)
            {
                int position = i + j;
                arrayResult[position] += (arrayFirst[i] * arraySecond[j]);
            }
        }
        return arrayResult;
    }
}

