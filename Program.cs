using System;
/*
Exercises C# working with strings - Reverse String
Date: 27/10/2020
*/
namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO C# Program to do reverse string
            Console.WriteLine("C# Program to do reverse string");
            Console.WriteLine("Enter the string:");
            String input = Console.ReadLine();
            // With Inbuilt Method Array.Reverse Method  
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reverse string is:");
            Console.WriteLine(charArray);
        }
    }
}
