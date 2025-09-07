// Strings.cs
using System;

namespace MyApp
{
    class Strings
    {
        public static void RunStringsExample()
        {
            // Declare and initialize string variables
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;

            // Print string values
            Console.WriteLine("=== Strings Example ===");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Length of Full Name: {fullName.Length}");
            Console.WriteLine($"Uppercase Full Name: {fullName.ToUpper()}");
            Console.WriteLine($"Lowercase Full Name: {fullName.ToLower()}");
            Console.WriteLine($"Contains 'Doe': {fullName.Contains("Doe")}");
            Console.WriteLine("Umesha \" Chamod"); // if you want to print double quotes inside a string
            Console.WriteLine(@"C:\Users\Umesha"); // to print file path use @ before string
            Console.WriteLine("My name is " + "Umesha"); // string concatenation
        }
    }
}