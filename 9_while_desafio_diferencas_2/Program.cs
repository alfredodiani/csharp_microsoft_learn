/*

Escrever o código que valida a entrada de cadeia de caracteres

    - A solução deve incluir uma iteração do-while ou while.

    - Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar 
    ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

    - Dentro do bloco de iteração:

        * A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
        * A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
        * A solução deve usar o método Trim() no valor de entrada para ignorar caracteres de espaço à direita e à esquerda.
        * A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
        * Se o valor inserido não corresponder a uma das opções de função, o código deverá usar uma 
        instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.

    - Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para 
    informar ao usuário que o valor de entrada foi aceito.
*/
Console.WriteLine("Type your role (Admin, Manager or User):");
string? role;
bool validRole = false;

do{
    role = Console.ReadLine();

    if (role is not null)
    {
        role = role.Trim().ToLower();
        if ((role == "admin") || (role == "manager") || (role == "user"))
            validRole = true;
        else
            Console.WriteLine("Invalid role! (Admin, Manager or User)");
    }
}while(!validRole);
Console.WriteLine($"Role accepted!\nWelcome {role}!");

Console.WriteLine