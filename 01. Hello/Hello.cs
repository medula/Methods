//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.

using System;
class Hello
{
    static void Main()
    {
        Console.Write("Please enter your name: ");
        sayHello(Console.ReadLine());
    }
    static void sayHello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}

