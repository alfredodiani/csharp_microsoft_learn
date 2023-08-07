/*
    Métodos internos para Strings:
        * Métodos que adicionam espaços em branco para fins de formatação (PadLeft(), PadRight())
        * Métodos que comparam duas cadeias de caracteres ou facilitam a comparação (Trim(), 
          TrimStart(), TrimEnd(), GetHashcode(), a propriedade Length)
        * Métodos que ajudam a determinar o que há dentro de uma cadeia de caracteres ou até mesmo
          recuperar apenas uma parte da cadeia de caracteres (Contains(), StartsWith(), EndsWith(), Substring())
        * Métodos que alteram o conteúdo da cadeia de caracteres substituindo, inserindo ou 
          removendo partes (Replace(), Insert(), Remove())
        * Métodos que transformam uma cadeia de caracteres em uma matriz de cadeias de caracteres
          ou de caracteres (Split(), ToCharArray())
*/

/*
    Espaçamentos

    PadLeft() adiciona espaços em branco ao lado esquerdo da cadeia de caracteres para 
    que o número total de caracteres seja igual ao argumento enviado por você. Nesse caso, 
    é interessante que o comprimento total da cadeia de caracteres seja 12 caracteres.
*/

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
Console.WriteLine("");


/*
    Exemplo
*/
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890"); //linha adicionada somente para verificar a formatação
Console.WriteLine(formattedLine);