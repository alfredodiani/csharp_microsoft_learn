/*
        Métodos auxiliares de arrays
*/

/*
    ToCharArray()
    transforma uma string em um array de char
*/
string word = "abc123";
char[] wordArray = word.ToCharArray();


/*
    Inverter e, em seguida, combinar a matriz char em uma nova cadeia de caracteres
*/
string palavra = "abc123";
char[] palavraArray = palavra.ToCharArray();
Array.Reverse(palavraArray);
string resultado = new string(palavraArray);
Console.WriteLine(resultado);
Console.WriteLine("");


/*
    String.Join()
    Combina todos os caracteres em uma nova cadeia de caracteres com valor separado por
    algum caractere escolhido (virgula no caso abaixo).
*/
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);
Console.WriteLine("");


/*
    Split()
    separa uma string com valor separado por algm caractere
    (virgula no caso abaixo) em uma matriz de cadeias de caracteres.
*/
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

