/*
    Conversão de tipos

    Há diversas técnicas para executar uma conversão de tipo de dados. A técnica escolhida depende de sua resposta a duas perguntas importantes:

        É possível, dependendo do valor, que a tentativa de alterar o tipo de dados do valor gerasse uma exceção em tempo de execução?
        É possível, dependendo do valor, que a tentativa de alterar o tipo de dados do valor resultasse em uma perda de informações?
*/

// GERA ERRO DE CONVERSÃO
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

//Converte com resultado inesperado
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);


/*
    perda de informações
*/
//código abaixo converte corretamente sem perda de informações
int myInt = 3;
Console.WriteLine($"int: {myInt}");
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

//código abaixo converte perdendo informações das casas decimais
decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");
int myInt2 = (int)myDecimal2;
Console.WriteLine($"int: {myInt2}");

//perde precisão na conversão abaixo devido ao tipo de dados
decimal varDecimal = 1.23456789m;
float varFloat = (float)varDecimal;
Console.WriteLine($"Decimal: {varDecimal}");
Console.WriteLine($"Float  : {varFloat}");


/*
    Use ToString() para converter um número em um string
*/
int firstNumber = 5;
int secondNumber = 7;
string message = firstNumber.ToString() + secondNumber.ToString();
Console.WriteLine(message);


/*
    Converter um string em um int usando o método auxiliar Parse()
*/
string thirdNumber = "5";
string fourthNumber = "7";
int sum = int.Parse(thirdNumber) + int.Parse(fourthNumber);
Console.WriteLine(sum);


/*
    Converter um string em um int usando a classe Convert
*/
string value1 = "5";
string value2 = "7";
int resultNumber = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(resultNumber);


/*
    Comparar a coerção e a conversão de um decimal em um int
*/
int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);


/*
    Utilizar o método TryParse() para analisar uma cadeia de caracteres como um int
*/
string valueNum = "102";
int resultNum = 0;
if (int.TryParse(valueNum, out resultNum))
{
    Console.WriteLine($"Measurement: {resultNum}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine($"Measurement (w/ offset): {50 + resultNum}");


/*
    Exemplo de uso TryParse() com variável de cadeia de caracteres para um valor que não possa ser transformado
*/
string valueN2 = "bad";
int resultN2 = 0;
if (int.TryParse(valueN2, out resultN2))
{
    Console.WriteLine($"Measurement: {resultN2}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (resultN2 > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + resultN2}");