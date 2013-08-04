//Write a method that checks if the element at given position in given array of integers is bigger than 
//its two neighbors (when such exist).
using System;
public class CheckNeighbors
{
    public static void Main()
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
        Console.Write("Choose an index from the array: ");
        int indexInput = int.Parse(Console.ReadLine());
        if (indexInput <= 0 || indexInput >= array.Length - 1)
        {
            Console.WriteLine("Index has to be a number between 1 and {0}", array.Length - 1);
        }
        else
        {
            bool isBigger = CheckElementIndex(array, indexInput);
            Console.WriteLine("Element with index {0} is bigger than its neighbors : {1}", indexInput, isBigger);
        }
    }
    public static bool CheckElementIndex(int[] arr, int checkedIndex)
    {
        bool check;

        if (arr[checkedIndex - 1] < arr[checkedIndex] && arr[checkedIndex] > arr[checkedIndex + 1])
        {
            check = true;
        }
        else
        {
            check = false;
        }
        return check;
    }
}

