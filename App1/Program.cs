using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! How can i call you:");
            string? name = Console.ReadLine();
            Console.Write("ohh, really, hello ");
            Console.WriteLine(name);
            Console.ReadKey();
            Console.WriteLine("how are u today?");
            Console.ReadLine();
            Console.WriteLine("ok, then ");
            Console.ReadKey();
            Console.WriteLine("let's work together :]");
        }
    }
}