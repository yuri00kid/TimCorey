string firstName;
Console.WriteLine("For quit , please type (exit)");

do
{
    Console.Write("What is your Name: ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine("Welcome Professor Corey.");
    }
    else if (firstName.ToLower() == "exit")
    {
        Console.WriteLine("End of the Program.");
    }
    else
    {
        Console.WriteLine("Welcome Student.");
    }
    
} while (firstName.ToLower() != "exit") ;

