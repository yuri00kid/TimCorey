
Console.WriteLine("After you finish , Type (done)");
Console.WriteLine("Please add Name of Students: ");


List<string> firstNames = new List<string>();
string name;
int count = 0;
do
{
    name = Console.ReadLine();
    firstNames.Add(name);
    count++;

} while (name.ToLower() != "done");


Console.WriteLine($"You type {count} Names .");
