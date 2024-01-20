

Dictionary<int, string> employes = new Dictionary<int, string>();

employes[1] = "Taha";
employes[2] = "Rahim";
employes[3] = "Tim";
employes[4] = "Jafar";
employes[5] = "Nader";

string idText;
Console.WriteLine("Finish = exit");
Console.Write("Give a ID to find employe: ");
do
{
    idText = Console.ReadLine();

    if (int.TryParse(idText, out int ID))
    {
        if (ID == 1)
        {
            Console.WriteLine(employes[1]);
        }
        else if (ID == 2)
        {
            Console.WriteLine(employes[2]);
        }
        else if (ID == 3)
        {
            Console.WriteLine(employes[3]);
        }
        else if (ID == 4)
        {
            Console.WriteLine(employes[4]);
        }
        else if (ID == 5)
        {
            Console.WriteLine(employes[5]);
        }
        else
        {
            Console.WriteLine("You type a wrong ID");
        }
    }
    else
    {
        Console.WriteLine("You type a wrong ID");
    }
} while (idText != "exit");

