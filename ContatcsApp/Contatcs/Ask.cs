using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Ask
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Contacts App.");
            Console.WriteLine("______________________________");
            Console.WriteLine("In this App , You can save some contacts and search them in the App.");
        }
        public static void InvalidMessage()
        {
            Console.WriteLine();
            Console.WriteLine("(Your answer is Invalid , Please try again !!!)");
            Console.WriteLine();
        }
        public static void EndMessage()
        {
            Console.WriteLine();
            Console.WriteLine("End of The Program.");
            Console.Write("Press any key to Exit.");
            Console.ReadLine();
        }
        public static string Continue()
        {
            Console.WriteLine();
            Console.Write("Do you want to Continue? (Yes/No):");
            string output = Console.ReadLine();
            return output;
        }
        public static void LoopContinue(string result)
        {
            while (true)
            {
                if (result.ToLower() == "yes")
                {
                    break;
                }
                else if (result.ToLower() == "no")
                {
                    Ask.EndMessage();
                    return;
                }
                else
                {
                    Ask.InvalidMessage();
                }
            }
        }

        public static string ToSearch()
        {
            Console.WriteLine();
            Console.Write("Do you want to Search into Contacts? (Yes/No) : ");
            string outputSearch = Console.ReadLine();
            return outputSearch;
        }
        public static string SearchSectionInfo()
        {
            Console.WriteLine();
            Console.WriteLine("In this section You can Search contacts with their Details.");
            Console.WriteLine();
            Console.WriteLine("Search with (First Name)   Type: 1");
            Console.WriteLine("Search with (Last Name)    Type: 2");
            Console.WriteLine("Search with (Phone Number) Type: 3");
            Console.WriteLine("Search with (City)         Type: 4");
            Console.WriteLine("End of Program.            Type: End");
            Console.Write("Type: ");
            string searchResult = Console.ReadLine();
            return searchResult.ToLower();
        }
        public static string HowmanyContact()
        {
            Console.WriteLine("How many contact do you want to add ? (type in Number)");
            Console.WriteLine("You can also skip this feature. (type <skip>)");
            Console.Write("Type: ");
            string input = Console.ReadLine();
            return input;
        }
        public static List<Person> IfIntParse(int numberOfContacts)
        {
            var Contacts = new List<Person>();
            for (int i = 1; i <= numberOfContacts; i++)
            {
                Console.WriteLine($"Person number {i}");
                var person = new Person();
                Console.Write("First Name of Contact: ");
                person.FirstName = Console.ReadLine();
                Console.Write("Last Name of Contact: ");
                person.LastName = Console.ReadLine();
                Console.Write("Phone Number of Contact: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("City of Contact: ");
                person.City = Console.ReadLine();

                Contacts.Add(person);

            }
            return Contacts;
        }
        public static List<Person> IfSkip()
        {
            var Contacts = new List<Person>();
            string anotherContact;
            int count = 1;
            do
            {
                Console.WriteLine($"Person Number {count}");
                count++;
                var person = new Person();
                Console.Write("First Name of Contact: ");
                person.FirstName = Console.ReadLine();
                Console.Write("Last Name of Contact: ");
                person.LastName = Console.ReadLine();
                Console.Write("Phone Number of Contact: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("City of Contact: ");
                person.City = Console.ReadLine();

                Contacts.Add(person);

                Console.Write("Do you want to Add another Contact? (Yes/No) :");
                anotherContact = Console.ReadLine();

            } while (anotherContact.ToLower() == "yes");
            return Contacts;
        }
        public static void LoopIntoContacts(List<Person> Contacts)
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName} /// Phone Number: {contact.PhoneNumber} /// City: {contact.City}");
            }
        }
        public static void SearchSection(List<Person> Contacts)
        {
            while (true)
            {
                
                string outputSearch = Ask.ToSearch();
                if (outputSearch.ToLower() == "yes")
                {

                    while (true)
                    {
                        string searchResult = Ask.SearchSectionInfo();
                        switch (searchResult)
                        {
                            case "1":
                                Ask.CaseFirstName(Contacts);
                                break;
                            case "2":
                                Ask.CaseLastName(Contacts);
                                break;
                            case "3":
                                Ask.CasePhoneNumber(Contacts);
                                break;
                            case "4":
                                Ask.CaseCityName(Contacts);
                                break;
                            case "end":
                                Ask.EndMessage();
                                return;
                            default:
                                Ask.InvalidMessage();
                                break; 
                        }
                        string result = Ask.Continue();
                        while (true)
                        {
                            if (result.ToLower() == "yes")
                            {
                                break;
                            }
                            else if (result.ToLower() == "no")
                            {
                                Ask.EndMessage();
                                return;
                            }
                            else
                            {
                                Ask.InvalidMessage();
                            }
                        }


                    }
                }
                else if (outputSearch.ToLower() == "no")
                {
                    Ask.EndMessage();
                    return;
                }
                else
                {
                    Ask.InvalidMessage();
                }

            };
        }
        public static void CaseFirstName(List<Person> Contacts)
        {
            Console.Write("First Name: ");
            string searchFirstName = Console.ReadLine();
            int countFirstName = 0;
            foreach (var contact in Contacts)
            {
                if (searchFirstName.ToLower() == contact.FirstName.ToLower())
                {
                    countFirstName++;
                    Console.WriteLine();
                    Console.WriteLine($"Name: {contact.FirstName} {contact.LastName} /// Phone Number: {contact.PhoneNumber} /// City: {contact.City}");
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Find {countFirstName} Result");
            
        }
        public static void CaseLastName(List<Person> Contacts)
        {
            Console.Write("Last Name: ");
            string searchLastName = Console.ReadLine();
            int countLastName = 0;
            foreach (var contact in Contacts)
            {
                if (searchLastName.ToLower() == contact.LastName.ToLower())
                {
                    countLastName++;
                    Console.WriteLine();
                    Console.WriteLine($"Name: {contact.FirstName} {contact.LastName} /// Phone Number: {contact.PhoneNumber} /// City: {contact.City}");
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Find {countLastName} Result");
        }
        public static void CasePhoneNumber(List<Person> Contacts)
        {
            Console.Write("Phone Number: ");
            string searchPhoneNumber = Console.ReadLine();
            int countPhoneNumber = 0;
            foreach (var contact in Contacts)
            {
                if (searchPhoneNumber.ToLower() == contact.PhoneNumber.ToLower())
                {
                    countPhoneNumber++;
                    Console.WriteLine();
                    Console.WriteLine($"Name: {contact.FirstName} {contact.LastName} /// Phone Number: {contact.PhoneNumber} /// City: {contact.City}");
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Find {countPhoneNumber} Result");
        }
        public static void CaseCityName(List<Person> Contacts)
        {
            Console.Write("City Name: ");
            string searchCityName = Console.ReadLine();
            int countCityName = 0;
            foreach (var contact in Contacts)
            {
                if (searchCityName.ToLower() == contact.City.ToLower())
                {
                    countCityName++;
                    Console.WriteLine();
                    Console.WriteLine($"Name: {contact.FirstName} {contact.LastName} /// Phone Number: {contact.PhoneNumber} /// City: {contact.City}");
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Find {countCityName} Result");
        }


    }
}
