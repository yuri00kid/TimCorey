

Console.Write("What is your name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "bob" ||
    firstName.ToLower() == "sue")
{
    Console.WriteLine("Hello Professor.");
}
else
{
    Console.WriteLine("Hello Student.");
}

Console.Write("How old are you: ");
string? ageText = Console.ReadLine();

int.TryParse(ageText, out int age);

if (age < 21)
{
    int waitTime = 21 - age;
    Console.WriteLine($"You must to wait {waitTime} years for this course.");
}
else
{
    Console.WriteLine($"Your age is {age}");
}
