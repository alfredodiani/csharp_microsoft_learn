/*
    Substitua os comentários de código do código inicial pelo seu próprio código para resolver o desafio:

    Solucionar para result1: dividir value1 por value2, exibir o resultado como int
    Solucionar para result2: dividir value2 por value3, exibir o resultado como decimal
    Solucionar para result3: dividir value3 por value1, exibir o resultado como float
    Resolva o desafio de modo que a sua saída seja semelhante a:
        Divide value1 by value2, display the result as an int: 2
        Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
        Divide value3 by value1, display the result as a float: 0.3583333
*/

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");