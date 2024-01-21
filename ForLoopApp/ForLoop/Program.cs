

Console.Write("Please type a couple Names with format of comma saparated (***,***,***): ");
string firstNames = Console.ReadLine();

List<string> listNames = firstNames.Split(',').ToList();

for (int i = 0; i < listNames.Count; i++)
{
    Console.WriteLine($"Hello {listNames[i]}");
}



