//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.
using System;

public class CountTimesAppear
{
    static void Main()
    {
        int[] array ={1,2,3,4,5,6,7,8,9,0,11,12,13,
                         6,7,8,9,10,11,12,13,14,15,16,17,17,
                         11,12,13,14,15,16,17,11,10,9,8,7,25,
                         19,20,21,23,25,16,17,18,23,18,19,20,21,
                         22,23,16,17,18,12,14,16,9,8,7,6,7};
        Console.WriteLine("This is the array: ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("{0} ", array[index]);
        }
        Console.WriteLine();
        Console.WriteLine("Choose an element from array: ");
        int chosenElement = int.Parse(Console.ReadLine());
        int result = CountNumbers(array, chosenElement);
        Console.WriteLine("Element {0} is appearing {1} times in array.", chosenElement, result);
    }
    public static int CountNumbers(int[] arr, int elementCounted)
    {
        int counts = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index] == elementCounted)
            {
                counts++;
            }
        }
        return counts;
    }
}
