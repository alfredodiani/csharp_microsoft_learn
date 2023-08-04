
/*
    Escrever o código que valida a entrada de inteiro

    * A solução deve incluir uma iteração do-while ou while.
    * Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar 
    ao usuário um valor inteiro entre 5 e 10.
    * Dentro do bloco de iteração:
    * A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
    * A solução deve garantir que a entrada seja uma representação válida de um inteiro.
    * Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() 
    para solicitar ao usuário um valor inteiro entre 5 e 10.
    * A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.
    * Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() 
    para informar ao usuário que o valor de entrada foi aceito.
*/

Console.WriteLine("Insert a number between 5 and 10");
string? userInput;
int number;
bool validNumber = false;

do {
    userInput = Console.ReadLine();
    if (!(int.TryParse(userInput, out number))){
        Console.WriteLine("Input is not a number, try again.");
    }else if ((number < 5) || (number > 10)) {
        Console.WriteLine("Input is not between 5 and 10, try again.");
    }else{
        validNumber = true;
    }
}while(!validNumber);

Console.WriteLine($"Number {userInput} accepted!");