

Console.WriteLine("This is an app to sing up in Class");


Console.Write("What is Your first name: ");
string? firstName = Console.ReadLine();

Console.Write("What is Your last name: ");
string lastName = Console.ReadLine();

if (firstName.ToLower() == "chris" && lastName.ToLower() == "hamilton" ||
    firstName.ToLower() == "sona" && lastName.ToLower() == "macer")
{
    Console.WriteLine($"Hello Professor {lastName} Welcome to the Class");
    return;
}
else
{
    Console.Write("How old are you: ");
    string? textAge = Console.ReadLine();

    if (int.TryParse(textAge, out int age))
    {
        if (age > 0 && age < 23)
        {
            Console.WriteLine($"Dear {firstName} {lastName} , We recommend you to wait {21 - age} Years to Start this Class");
            return;
        }
        else if (age <= 0)
        {
            Console.WriteLine("Please type a Number Greater than (Zero)");
        }
        else
        {
            Console.WriteLine($"Hello {firstName} {lastName} , Welcome to the Class");
        }
        
    }
    else
    {
        Console.WriteLine("Please type a valid Number in format of (Integer)");
    }
;
}

