
Console.WriteLine("Finish = done");

Console.Write("Give us The Names: ");
string firstNames;
List<string> listNames = new();
do
{
    firstNames =  Console.ReadLine();
    listNames.Add(firstNames);

} while (firstNames.ToLower() != "done");

foreach (string firstName in listNames)
{
    Console.WriteLine($"Hello {firstName}");
}

