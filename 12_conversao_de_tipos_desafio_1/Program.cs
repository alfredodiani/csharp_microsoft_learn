/*
    Crie uma estrutura de loop a ser usada na iteração por cada valor de cadeia de caracteres na matriz values.
    string[] values = { "12,3", "45", "ABC", "11", "DEF" };

    Conclua o código necessário, colocando-o dentro do bloco de código da estrutura de loop da matriz. 
    É necessário implementar as seguintes regras de negócio na lógica do código:
        Regra 1: se o valor for alfanumérico, concatene-o para formar uma mensagem.
        Regra 2: se o valor for numérico, adicione-o ao total.
        Regra 3: o resultado deve corresponder à seguinte saída:
            Message: ABCDEF
            Total: 68,3
*/

string[] values = { "12,3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0.0m;

foreach (string item in values)
{
    if(decimal.TryParse(item, out decimal myNumber))
    {
        total += myNumber;
    }
    else
    {
        message += item;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
