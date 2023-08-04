/*
    Neste desafio, você implementará um operador condicional para simular um "lançamento de moeda". 
    A lógica de decisão resultante exibirá heads ou tails.
*/

Console.WriteLine("***** Cara ou coroa *****");

Random rnd = new Random();
int lancamento = rnd.Next(1, 101);

string resultado = (lancamento <= 50) ? "CARA" : "COROA";

Console.WriteLine($"O resultado do lançamento foi {resultado}");
