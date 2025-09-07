using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World !");
            await Task.Delay(1000);
            Console.WriteLine("Goodbye, World !");
        }
    }
}