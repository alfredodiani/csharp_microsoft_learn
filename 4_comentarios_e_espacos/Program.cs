/*
    Nomeie as variáveis e classes com nomes bem definidos e sem abreviações.
    Utilize estilo camelCase para nomeação.
    Somente uma instrução completa por linha de código.
    Utilize espaços em branco para separar linhas de código por contexto.
    Também é recomendado utilizar indentação de blocos aninhados.
*/

/*
* Inverte uma cadeia de caracteres e conta o número de vezes que 
* um caractere específico é exibido.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char letter in charMessage)
{
    if (letter == 'o') 
    { 
        letterCount++; 
    }
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");