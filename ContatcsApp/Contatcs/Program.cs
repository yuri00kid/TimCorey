using Contacts;

Ask.Welcome();
var Contacts = new List<Person>();
do
{
    string outputHowmany = Ask.HowmanyContact();

    if (int.TryParse(outputHowmany, out int numberOfContacts))
    {
        Contacts = Ask.IfIntParse(numberOfContacts);
        Ask.LoopIntoContacts(Contacts);
        Ask.SearchSection(Contacts);
        return;
    }
    else if (outputHowmany.ToLower() == "skip")
    {
        Contacts = Ask.IfSkip();
        Ask.LoopIntoContacts(Contacts);
        Ask.SearchSection(Contacts);
        return;
    }
    else
    {
        Ask.InvalidMessage();
    }

} while (true);




