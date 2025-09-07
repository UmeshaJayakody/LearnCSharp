using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Learning Examples ===\n");
            
            // Run Variables example
            Variables.RunVariablesExample();
            
            Console.WriteLine(); // Add empty line
            
            // Run Data Types example
            DataTypes.RunDataTypesExample();
            
            Console.WriteLine(); // Add empty line
            
            // Run Strings example
            Strings.RunStringsExample();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}