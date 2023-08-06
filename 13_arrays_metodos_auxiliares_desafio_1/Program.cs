/*

Escrever código para inverter cada palavra de uma mensagem
Selecione e exclua todas as linhas de código no Editor do Visual Studio Code.

Atualize seu código no Editor do Visual Studio Code da seguinte maneira:
--- string pangram = "The quick brown fox jumps over the lazy dog"; ---

Escreva o código necessário para inverter as letras de cada palavra no lugar 
e exibir o resultado.
Em outras palavras, não basta inverter todas as letras na variável pangram. 
Em vez disso, você precisará inverter apenas as letras de cada palavra, mas 
imprimir a palavra invertida em sua posição original na mensagem.
Seu código deverá produzir a seguinte saída:

Output:
ehT kciuq nworb xof spmuj revo eht yzal god

*/

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramArray = pangram.Split(" ");
string[] reversedWordsPangramArray = new string[pangramArray.Length];

for (int i = 0; i < pangramArray.Length; i++) 
{
    char[] word = pangramArray[i].ToCharArray();
    Array.Reverse(word);
    reversedWordsPangramArray[i] = new string (word);
}

Console.WriteLine(String.Join(" ", reversedWordsPangramArray));