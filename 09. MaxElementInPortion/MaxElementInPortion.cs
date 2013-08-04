//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
class MaxElementInPortion
{
    static void Main()
    {
        int[] array ={1,2,3,4,5,76,1117,8,9,0,
                      11,12,13,6,7,80,91,110,11,12,
                      13,14,15,16,17,17,11,12,103,24,
                      14,15,16,17,1111,10,9,8,7,25,
                      19,20,201,203,25,16,17,2318,23,18,
                      22,23,16,197,178,125,1442,116,9,8};

        //finds maximal element in portion of array
        Console.WriteLine("Enter starting index of the portion ");
        int inputIndex = int.Parse(Console.ReadLine());
        int[] arrayNew = new int[array.Length - inputIndex];
        for (int i = inputIndex, k = 0; i < (array.Length); i++, k++)
        {
            arrayNew[k] = array[i];
        }
        int result = MaxElementInPortionOfArray(inputIndex, arrayNew);
        Console.WriteLine("Maximal element in portion of array is {0}", result);

        //sorting array in descending order
        int swapIndex = 0;
        for (int count = 0; count < array.Length; count++)
        {
            int[] arrayNew1 = new int[array.Length - count];
            for (int i1 = count, k1 = 0; i1 < (array.Length); i1++, k1++)
            {
                arrayNew1[k1] = array[i1];
            }
            int tempElement = array[count];
            array[count] = MaxElementInPortionOfArray(count, arrayNew1);
            swapIndex = MaxElementIndexInPortionOfArray(count, arrayNew1);
            array[swapIndex] = tempElement;
        }
        Console.WriteLine("Array in descending order: ");
        for (int step = 0; step < array.Length; step++)
        {
            Console.Write(array[step] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        //sorting array in ascending order
        Array.Reverse(array);
        Console.WriteLine("Array in ascending order: ");
        for (int step = 0; step < array.Length; step++)
        {
            Console.Write(array[step] + " ");
        }
    }
    static int MaxElementInPortionOfArray(int startIndex, int[] arr)
    {
        int maxElement = int.MinValue;
        for (int index1 = 0; index1 < arr.Length; index1++)
        {
            if (arr[index1] > maxElement)
            {
                maxElement = arr[index1];
            }
        }
        return maxElement;
    }
    static int MaxElementIndexInPortionOfArray(int startIndex, int[] arr)
    {
        int maxElement = int.MinValue;
        int maxIndex = 0;
        for (int index1 = 0; index1 < arr.Length; index1++)
        {
            if (arr[index1] > maxElement)
            {
                maxElement = arr[index1];
                maxIndex = index1;
            }
        }
        return startIndex + maxIndex;
    }
}


