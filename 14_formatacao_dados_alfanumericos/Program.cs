/*
    Formatação composta
*/

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);

Console.WriteLine(result);
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);


/*
    Interpolação
    Utiliza $ no inicio e adiciona a variável entre chaves para interpolar
*/

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
Console.WriteLine("");


/*
    MOEDA
    utiliza-se :C para formatar o valor na moeda configurada para o país/região em uso
*/
decimal preco = 123.45m;
int desconto = 50;
Console.WriteLine($"Preço: {preco:C} (Desconto: {desconto:C})");


/*
    NÚMEROS
    Utiliza-se :N para formatar de acordo com o país/região
    Também utiliza-se :N3 (onde 3 é o numero de casas decimais)
*/
decimal measurement = 123456.78912m;
Console.WriteLine($"Medição: {measurement:N} unidades");
Console.WriteLine($"Medição: {measurement:N4} unidades");


/*
    PERCENTUAIS
    :P
    :P3 para definir as casas decimais
*/
decimal tax = .36785m;
Console.WriteLine($"Imposto: {tax:P}");
Console.WriteLine($"Imposto: {tax:P4}");


/*
    Combinando diferentes tipos de formatação
*/
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price); //utilizando String.Format

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //sem utilizar String.Format
Console.WriteLine(yourDiscount);