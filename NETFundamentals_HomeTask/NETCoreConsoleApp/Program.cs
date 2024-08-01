using NETLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? username = String.Empty;         

            if (args.Length  > 0)
            {
                username = args[0];                
            }
            else
            {
                Console.WriteLine("Please enter a username: ");
                username = Console.ReadLine();
            }

            Console.WriteLine(HelloWorldLibrary.Concatenation(username));
        }
    }
}
