//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArrayNFactorial
{
    static void Main()
    {
        List<List<int>> arrayNFactorial = new List<List<int>>();
        List<int> nFactorial = new List<int>();
        arrayNFactorial.Add(ConvertNumberToArray(1));

        for (int number = 2; number <= 99; number++)
        {
            List<int> numberToDigits = ConvertNumberToArray(number);
            List<int> member = MultiplyArray(numberToDigits, arrayNFactorial[number - 2]);

            arrayNFactorial.Add(member);
        }
        //for (int i = 0; i < arrayNFactorial.Count; i++)
        //{
        //    for (int j = arrayNFactorial[i].Count - 1; j >= 0; j--)
        //    {
        //        Console.Write("{0 }", arrayNFactorial[i][j]);
        //    }
        //    Console.WriteLine();
        //}
        Console.WriteLine("Enter number in range [1..100]");
        int factorialSearched = int.Parse(Console.ReadLine());
        if (factorialSearched == 100)
        {
            Console.WriteLine("Factoriel of number 100 is : 4527721802653776847145980159648764542776941837843497190344377428331229452121353971063539158299693896428020640640827223758251185210916864000000000000000000000000");
        }
        else
        {
            Console.WriteLine("Factoriel of number {0} is :", factorialSearched);
            for (int j = arrayNFactorial[factorialSearched - 1].Count - 1; j >= 0; j--)
            {
                Console.Write("{0 }", arrayNFactorial[factorialSearched - 1][j]);
            }
            Console.WriteLine();
        }
    }

    static List<int> ConvertNumberToArray(int number)
    {
        List<int> arrayDigits = new List<int>();
        while (number >= 1)
        {
            arrayDigits.Add(number % 10);
            number /= 10;
        }
        return arrayDigits;

    }
    static List<int> MultiplyArray(List<int> nextNumber, List<int> factorial)
    {
        List<List<int>> tempResult = new List<List<int>>();
        int carry = 0;
        for (int i = 0; i < nextNumber.Count; i++)
        {
            List<int> tempList = new List<int>();
            for (int j = 0; j < factorial.Count; j++)
            {
                int product = nextNumber[i] * factorial[j] + carry;
                if (product < 10)
                {
                    tempList.Add(product);
                    carry = 0;
                }
                else
                {
                    tempList.Add(product % 10);
                    carry = product / 10;
                }
            }
            if (carry > 0)
            {
                tempList.Add(carry);
                carry = 0;
            }
            tempResult.Add(tempList);
        }

        List<int> result = new List<int>();
        int sum1 = 0;
        if (tempResult.Count == 1)
        {
            for (int i = 0; i < tempResult[0].Count; i++)
            {
                result.Add(tempResult[0][i]);
            }
        }
        else if (tempResult[0].Count <= tempResult[1].Count)
        {
            for (int index = 0; index <= tempResult[1].Count; index++)
            {
                //first index of first sum is summed alone
                if (index == 0)
                {
                    result.Add(tempResult[0][0]);
                    continue;
                }
                //if first sum has finished, sum up only of elements from second sum

                if (index == tempResult[0].Count)
                {
                    sum1 = tempResult[1][index - 1] + carry;
                    carry = 0;
                }
                else if (index < tempResult[1].Count)
                {
                    sum1 = tempResult[0][index] + tempResult[1][index - 1] + carry;
                }
                if (sum1 < 10)
                {
                    result.Add(sum1);
                    carry = 0;
                }
                else
                {
                    result.Add(sum1 % 10);
                    carry = sum1 / 10;
                }
            }
        }
        else
            for (int index = 0; index < tempResult[0].Count; index++)
            {
                if (index == 0)
                {
                    result.Add(tempResult[0][0]);
                    continue;
                }
                if (index > tempResult[1].Count)
                {
                    sum1 = tempResult[0][index] + carry;
                    carry = 0;
                }
                else if (index <= tempResult[1].Count)
                {
                    sum1 = tempResult[0][index] + tempResult[1][index - 1] + carry;
                }
                if (sum1 < 10)
                {
                    result.Add(sum1);
                    carry = 0;
                }
                else
                {
                    result.Add(sum1 % 10);
                    carry = sum1 / 10;
                }
            }
        if (carry > 0)
        {
            result.Add(carry);
            carry = 0;
        }
        return result;
    }
}




