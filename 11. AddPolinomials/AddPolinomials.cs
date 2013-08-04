// Write a method that adds two polynomials. Represent them as arrays of their coefficients.

using System;

    class AddPolinomials
    {
        static void Main()
        {
            int[] arrayFirst = { 4, 5, 0, 6, 7 };
            int[] arraySecond = {6, 7};
            int[] arrayResult = SumPolinomials(arrayFirst, arraySecond);
           Array.Reverse(arrayResult);
           for (int index = 0; index < arrayResult.Length; index++)
           {
               Console.Write("{0} ", arrayResult[index]);
           }
        }

        private static int[] SumPolinomials(int[] arrayFirst, int[] arraySecond)
        {
            Array.Reverse(arrayFirst);
            Array.Reverse(arraySecond);
            int arrayResultLength = Math.Max(arrayFirst.Length, arraySecond.Length);
            int minLength = Math.Min(arrayFirst.Length, arraySecond.Length);
            int[] arrayResult = new int[arrayResultLength];
            for (int i = 0; i < minLength; i++)
            {
                arrayResult[i] = arrayFirst[i] + arraySecond[i];
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
    }

