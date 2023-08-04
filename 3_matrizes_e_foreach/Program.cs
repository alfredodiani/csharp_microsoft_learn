/**
* Arrays
*/

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
*/



string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent order to process.\n");


/**
*   foreach
*/

string[] names = { "Rowena", "Robin", "Bao" };

foreach (string name in names)
{
    Console.WriteLine($"Nome: {name}");
}

Console.WriteLine();

//-----

int[] inventory = { 200, 450, 700, 175, 250 };
int sumItems = 0;
int bin = 0;

foreach (int items in inventory)
{
    bin++;
    sumItems += items;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sumItems})");
}

Console.WriteLine($"Number of items in the inventory: {sumItems}");
