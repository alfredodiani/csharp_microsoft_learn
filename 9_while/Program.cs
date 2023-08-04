/*
    while
*/

/*
Vamos escrever código que continuará gerando números aleatórios entre 1 e 10 
até que o número 7 seja gerado. Pode ser preciso apenas uma iteração para 
obter o número 7, ou pode ser necessário dezenas de iterações.
*/

Random rand = new Random();
int minValue = 1;
int maxValue = 10;
int targetValue = 7;
int currentNumber = 0;

do{
    currentNumber = rand.Next(minValue, maxValue);
    Console.WriteLine(currentNumber);
}while (currentNumber != targetValue);

/*
Escrever uma instrução while que itere somente enquanto um número aleatório for maior que determinado valor
*/
int current = rand.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = rand.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");


/*
    Usar a instrução continue para passar diretamente para a expressão booliana
*/
do
{
    current = rand.Next(1, 11);

    if (current >= 8) 
        continue;

    Console.WriteLine(current);
} while (current != 7);