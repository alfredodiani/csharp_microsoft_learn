
string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;


/*
A parameter becomes optional when it's assigned a default value. If an optional parameter is omitted from the arguments, 
the default value is used when the method executes. In the following method parameters partySize, allergies and inviteOnly are optional.
*/
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

/*
Notice that you supply the name of the parameter, followed by a colon and the value. 
This syntax defines a named argument. It isn't necessary to name all of the arguments. 
For example, the following syntax is also valid:

*/

RSVP("Rebecca");    //optional parameters are not being omited and receiving the default value
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false); //using named arguments
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true); //using named arguments for ags 2, 3 and 4. arg 1 is defined by placement
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);

ShowRSVPs();
