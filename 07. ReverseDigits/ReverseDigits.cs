//Write a method that reverses the digits of given decimal number. Example: 256  652
using System;

    class ReverseDigits
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = ReverseNumber(number);
            Console.WriteLine("Reversed number looks like: {0} ",reversedNumber);
        }
        static int ReverseNumber(int decimalNumber)
        {
            string newNumber = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 10;
                string newDigit = remainder.ToString();
                newNumber += newDigit;
                decimalNumber/=10;
            }
            int reverseNumber = int.Parse(newNumber);
            return reverseNumber;
        }
    }

