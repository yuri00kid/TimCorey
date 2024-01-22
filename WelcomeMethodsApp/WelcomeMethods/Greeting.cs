using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMethods
{
    internal class Greeting
    {
        public static string GetUsersName()
        {
            Console.Write("What is Your Name: ");
            string name = Console.ReadLine();
            return name;
        }
        
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}.");
            Console.WriteLine("I Hope you have a Nice day.");
        }
    }
}
