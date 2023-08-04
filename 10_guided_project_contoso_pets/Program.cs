/*
       0 ID 
       1 Species
       2 Age
       3 Nickname
       4 Physical description
       5 Personality
*/

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

string getFieldDescription(int desc)
{
    switch (desc)
    {
        case 0:
            return "ID #: ";
        case 1:
            return "Species: ";
        case 2:
            return "Age: ";
        case 3:
            return "Nickname: ";
        case 4:
            return "Physical description: ";
        case 5:
            return "Personality: ";
        default:
            return "";
    }
}

int getCurrentPetsRegistered()
{
    int petCounter = 0;
    for (int i = 0; i < maxPets; i++)
    {
        if (!(string.IsNullOrEmpty(ourAnimals[i, 0])))
        {
            petCounter++;
        }
    }
    return petCounter;
}



// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }


    ourAnimals[i, 0] = animalID;
    ourAnimals[i, 1] = animalSpecies;
    ourAnimals[i, 2] = animalAge;
    ourAnimals[i, 3] = animalNickname;
    ourAnimals[i, 4] = animalPhysicalDescription;
    ourAnimals[i, 5] = animalPersonalityDescription;
}

// display the top-level menu options


do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (!(string.IsNullOrEmpty(ourAnimals[i, 0])))
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(getFieldDescription(j));
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // add new animal
            int petCount = getCurrentPetsRegistered();
            Console.WriteLine($"We currently have {petCount} pets that need homes.\nWe can manage{maxPets}");
            string addAnotherPet = "y";
            bool validEntry = false;
            while ((addAnotherPet == "y") && (petCount < maxPets))
            {
                Console.WriteLine("Type data for the pet you want to add:");
                for (int j = 1; j < 6; j++)
                {
                    do
                    {
                        validEntry = false;

                        Console.Write(getFieldDescription(j));
                        readResult = Console.ReadLine();
                        // if(readResult == null){
                        //     continue;
                        // }
                        readResult = readResult.Trim().ToLower();

                        if (j == 1)
                        {
                            if (readResult == "cat" || readResult == "dog")
                            {
                                validEntry = true;
                            }
                            else
                            {
                                Console.WriteLine("Type cat or dog.");
                            }
                        }
                        else if (j == 2)
                        {
                            if (int.TryParse(readResult, out int age))
                            {
                                validEntry = true;
                            }
                        }
                        else
                        {
                            validEntry = true;
                        }
                    } while (!(validEntry));

                    ourAnimals[petCount, j] = readResult.Trim().ToLower();
                }
                ourAnimals[petCount, 0] = ourAnimals[petCount, 1].Substring(0, 1) + (petCount + 1).ToString();
                Console.WriteLine("Animal added!");

                Console.WriteLine("Do you want to add another pet? (Y)es (N)o");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    addAnotherPet = readResult.ToLower();
                }
                petCount++;
            }

            if (petCount == maxPets)
            {
                Console.WriteLine("Sorry! Max pet capacity reached.");
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "")
                {
                    if (!(int.TryParse(ourAnimals[i, 2], out int a)))
                    {
                        do
                        {
                            Console.WriteLine($"Animal ID: {ourAnimals[i, 0]}\nEnter animal Age: ");
                            readResult = Console.ReadLine();
                            
                        }while(!(int.TryParse(readResult, out int b)));
                        ourAnimals[i, 2] = readResult;
                    }
                    if (ourAnimals[i,4] == "" || ourAnimals[i,4] == "?")
                    {
                        do
                        {
                            Console.WriteLine($"Animal ID: {ourAnimals[i, 0]}\nEnter animal Physical description: (size, color, breed, gender, weight, housebroken)");
                            readResult = Console.ReadLine();
                        }while(readResult == null || readResult == "" || readResult == "?");
                        ourAnimals[i, 4] = readResult;
                    }
                }
            }
            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "")
                {
                    if (ourAnimals[i,3] == "" || ourAnimals[i,3] == "?")
                    {
                        do
                        {
                            Console.WriteLine($"Animal ID: {ourAnimals[i, 0]}\nEnter pet nickname: ");
                            readResult = Console.ReadLine();
                            
                        }while(readResult == null || readResult == "" || readResult == "?");
                        ourAnimals[i, 3] = readResult;
                    }
                    if (ourAnimals[i,5] == "" || ourAnimals[i,5] == "?")
                    {
                        do
                        {
                            Console.WriteLine($"Animal ID: {ourAnimals[i, 0]}\nEnter pet personality description: (likes or dislikes, tricks, energy level)");
                            readResult = Console.ReadLine();
                            
                        }while(readResult == null || readResult == "" || readResult == "?");
                        ourAnimals[i, 5] = readResult;
                    }
                }
            }
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

    }

} while (menuSelection != "exit");


// pause code execution
readResult = Console.ReadLine();
