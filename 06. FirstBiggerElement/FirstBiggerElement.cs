//Write a method that returns the index of the first element in array that is bigger than its neighbors, 
//or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstBiggerElement
{
    static void Main()
    {
        int[] arr ={1,42,53,4,5,6,7,8,9,0,11,12,13,
                      6,7,8,9,10,11,12,13,14,15,16,17,17,
                      111,12,113,14,15,16,7,1,10,9,8,7,25,
                      191,20,221,23,254,163,17,8,23,18,19,20,21,
                      252,23,165,17,18,12,14,16,9,8,7,6,7};
        Console.WriteLine("This is the array: ");
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("{0} ", arr[index]);
        }
        Console.WriteLine();
        for (int index = 1; index < arr.Length-2; index++)
        {
            int result = CheckElementIndex(arr, index);
            if (result == 0)
            {
                continue;
            }
            if (result!=-1)
            {
                Console.WriteLine("Index of the first element in the array that is bigger than its neighbors is {0}", result);
                break;
            }
            else if (result==-1)
            {
                Console.WriteLine(" Function returns result -1 , which means there is no element in array that is bigger than its neighbours.");
            }
        }
    }
        public static int CheckElementIndex(int[] arr, int checkedIndex)
    {
       

        if (arr[checkedIndex - 1] < arr[checkedIndex] && arr[checkedIndex] > arr[checkedIndex + 1])
        {
            return checkedIndex;
        }
        else if (checkedIndex == arr.Length - 1)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
       
   }

    


