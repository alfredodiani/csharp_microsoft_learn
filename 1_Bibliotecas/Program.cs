/*
* Chamadas de métodos com instancia:
* requer que uma instancia da classe seja criada para chamar o método
* O método Next() da classe Random é um exemplo que necessita de instancia
*/
Random dado = new Random();
int rolar = dado.Next(1,7);
Console.WriteLine(rolar);

/*
* Chamadas de métodos com sobrecarga
* O método Next() da classe Random possúi diferentes implementações
* cada uma com diferentes tipos e números de parâmetros
*/

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

/*
* Desafio, retorna o maior de dois numeros:
*/

int numero1 = 7;
int numero2 = 16;

int largerValue = System.Math.Max(numero1, numero2);

Console.WriteLine($"Maior valor entre {numero1} e {numero2}: {largerValue}");