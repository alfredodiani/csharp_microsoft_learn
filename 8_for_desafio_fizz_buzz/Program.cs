/*
Aqui estão as regras do FizzBuzz que você precisa implementar em seu projeto de código:

Valores de saída de 1 a 100, um número por linha, dentro do bloco de código de uma instrução de iteração.
Quando o valor atual é divisível por 3, imprima o termo Fizz ao lado do número.
Quando o valor atual é divisível por 5, imprima o termo Buzz ao lado do número.
Quando o valor atual é divisível tanto por 3 quanto por 5, imprima o termo FizzBuzz ao lado do número.
*/

for (int i = 1; i <= 100; i++){
    Console.Write(i);
    if ((i%3 == 0) && (i%5 == 0))
        Console.Write(" - FizzBuzz");
    else if (i%3 == 0)
        Console.Write(" - Fizz");
    else if (i%5 == 0)
        Console.Write(" - Buzz");
    Console.Write("\n");
}