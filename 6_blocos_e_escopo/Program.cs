/*
    Escopo de variável
*/

bool flag = true;
int value = 0;

if (flag)
{
    //int value;
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

Console.WriteLine($"Outside of code block: {value}");

/*
    Remoção de chaves para blocos com 1 única linha
*/
bool flag1 = true;
if (flag1)
    Console.WriteLine(flag);

/*
    Legibilidade
    Não deixar varias instruções na mesma linha
*/

// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");

//melhorando o código acima

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");