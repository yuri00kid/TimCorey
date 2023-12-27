// Ask for the Age

Console.Write("How old are you? : ");
string? ageString = Console.ReadLine();

// Converting ageString to an int number 

bool isValid = int.TryParse(ageString, out int age);
Console.WriteLine($"Is this Valid? {isValid}. The number was: {age}");

// Doing the math thing
int ageAfter = age + 25;
Console.WriteLine($"After 25 years you will be {ageAfter} years old");

int ageEarlier = age - 25;
Console.WriteLine($"25 years Earlier you was at {ageEarlier} years old");


    