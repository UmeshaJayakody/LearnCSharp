// Variables.cs
using System;

namespace MyApp
{
    class Variables
    {
        public static void RunVariablesExample()
        {
            // Declare and initialize variables
            int age = 30;
            string name = "John";
            bool isEmployed = true;

            // Print variable values
            Console.WriteLine("=== Variables Example ===");
            Console.WriteLine("Variable Values: " + name + " , " + age + " , " + isEmployed);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employed: {isEmployed}");
        }
    }
}