// DataTypes.cs
using System;

namespace MyApp
{
    class DataTypes
    {
        public static void RunDataTypesExample()
        {
            // Declare variables of different data types
            int age = 30; // integer // whole number
            float height = 5.9f;  // floating point  // use 'f' suffix for float literals
            decimal balance = 1000.50m; // decimal  // for precise financial calculations
            double salary = 50000.50; // double
            char grade = 'A'; // character
            string name = "John Doe"; // string
            bool isEmployed = true; // boolean

            // Print variable values
            Console.WriteLine("=== Data Types Example ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Employed: {isEmployed}");
        }
    }
}