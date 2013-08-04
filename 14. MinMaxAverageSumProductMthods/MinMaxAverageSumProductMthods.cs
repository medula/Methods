// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.

using System;
using System.Collections.Generic;

class MinMaxAverageSumProductMthods
{
    static void Main()
    {
        Console.Write("Enter number of elements in the set: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Min element is {0}", MinFromSet(array));
        Console.WriteLine("Max element is {0}", MaxFromSet(array));
        Console.WriteLine("Average of elements is {0}", AverageFromSet(array));
        Console.WriteLine("Sum of elements is {0}", SumFromSet(array));
        Console.WriteLine("Product of elements is {0}", ProductFromSet(array));

    }
    static int MinFromSet(params int[] elements)
    {
        int minElement = int.MaxValue;
        for (int index = 0; index < elements.Length; index++)
        {
            if (elements[index] < minElement)
            {
                minElement = elements[index];
            }
        }
        return minElement;
    }
    static int MaxFromSet(params int[] elements)
    {
        int maxElement = int.MinValue;
        for (int index = 0; index < elements.Length; index++)
        {
            if (elements[index] > maxElement)
            {
                maxElement = elements[index];
            }
        }
        return maxElement;
    }
    static float AverageFromSet(params int[] elements)
    {
        float averageElement;
        int sum = 0;
        for (int index = 0; index < elements.Length; index++)
        {
            sum += elements[index];
        }
        averageElement = sum /( elements.Length);
        return averageElement;
    }
    static int SumFromSet(params int[] elements)
    {
        int sum = 0;
        for (int index = 0; index < elements.Length; index++)
        {
            sum += elements[index];
        }
       return sum;
    }
    static decimal ProductFromSet(params int[] elements)
    {
        decimal product = 1;
        for (int index = 0; index < elements.Length; index++)
        {
            product *= elements[index];
        }
        return product;
    }
}

