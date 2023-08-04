/*
    Operador de igualdade
*/
Console.WriteLine("\nIgualdade");
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");


/*
    Operador de desigualdade
*/
Console.WriteLine("\nDesigualdade");
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");


/*
    usar Trim(), ToLower() e ToUpper()
*/
Console.WriteLine("\nTrim(), ToLower() e ToUpper()");
string value1 = " a";
string value2 = "A ";
Console.WriteLine($"{value1} : {value2}");
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

string value3 = "b";
string value4 = "B";
Console.WriteLine($"{value3} : {value4}");
Console.WriteLine(value3.ToUpper() == value3.ToUpper());

/*
    Comparações
*/
Console.WriteLine("Comparações");
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

/*
    Método string.Contains()
*/
Console.WriteLine("Contains()");
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

/*
    Negação lógica
*/
Console.WriteLine("Negação");
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

/*
    Operador Condicional - Ternario

    <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
*/
Console.WriteLine("Operador Condicional - Ternario");

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
//ou
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
