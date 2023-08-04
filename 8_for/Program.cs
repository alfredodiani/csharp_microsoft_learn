/*
    for
    implementação básica
*/
for (int i = 0; i < 10 ; i++)
{
    Console.WriteLine(i);
}


/*
    for contando inverso
*/
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}


/*
    for contando de 3 em 3
*/
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}


/*
    utilizando Break para parar o loop
*/
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
        break;
}

/*
    utilizando for para iterar um array
*/
string[] names = {"Alex", "John", "Smith", "Albert", "Peter"};
for (int i = names.Length - 1; i >= 0 ; i--)
{
    Console.WriteLine(names[i]);
}

/*
    alteranndo dados dentro de um loop
    nota: algo que não é possivel utilizando foreach

    string[] names = { "Alex", "Eddie", "David", "Michael" };
    foreach (var name in names)
    {
        // Can't do this:
        if (name == "David") name = "Sammy";
    }
*/

string[] names2 = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names2.Length; i++)
{
    if (names2[i] == "David")
        names2[i] = "Sammy";
}

foreach (string name in names2)
    Console.WriteLine(name);



