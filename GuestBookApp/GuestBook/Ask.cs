using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class Ask
    {
        public static List<string>  GetNames()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("After Finish type: (done)");
            List<string> listNames = new();
            string firstName;
            do
            {
                Console.Write("Enter a Name: ");
                firstName = Console.ReadLine();
                if (firstName != "done")
                {
                    listNames.Add(firstName);
                }
                
            } while (firstName.ToLower() != "done");
            return  listNames ;
            
        }

        public static void ReadAndCount(List<string> guestNames)
        {
            int count = 0;
            foreach (string guestName in guestNames)
            {
                Console.Write($"({guestName}),");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine($"Your guests Are : {count} persons.");
            Console.WriteLine("Press any key to quit.");
            Console.ReadLine();
        }
    }
}
