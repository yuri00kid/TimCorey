

string[] firstNames = new string[] { "Tim", "Charles", "Ray" };

Console.WriteLine("Please took a Name by a number between (1 to 3)");
Console.WriteLine("Type (exit) to shut down the Program");

string textNumber; 

do
{

    textNumber = Console.ReadLine();

    if (int.TryParse(textNumber, out int number))
    {
        if (number == 1)
        {
            Console.WriteLine(firstNames[0]);
        }
        else if (number == 2)
        {
            Console.WriteLine(firstNames[1]);
        }
        else if (number == 3)
        {
            Console.WriteLine(firstNames[2]);
        }
        else
        {
            Console.WriteLine("Please took a Name by a number between (1 to 3)");
        }

    }
    else
    {
        Console.WriteLine("Please took a Name by a number between (1 to 3)");
    }
;

} while (textNumber.ToLower() != "exit");

     