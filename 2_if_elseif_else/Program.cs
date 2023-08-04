/*
* Você usará o método Random.Next() para simular a rolagem de três dados de seis lados cada. Você avaliará os valores para calcular a pontuação. Se a pontuação for superior a um total arbitrário, você exibirá uma mensagem de vitória para o usuário. Se a pontuação estiver abaixo do corte, você exibirá uma mensagem de derrota para o usuário.
* 
* Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.
* Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.
* Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for igual ou maior que 15, você vencerá o jogo. Caso contrário, você perderá.
* 
* Para deixar o jogo mais divertido, em vez de uma mensagem de "vitória" ou "derrota", você pode mudar para a concessão de prêmios fictícios para cada pontuação. Você pode oferece quatro prêmios. No entanto, o jogador deve ganhar apenas um prêmio:
* 
* Se a pontuação do jogador for maior ou igual a 16, ele ganhará um carro novo.
* Se a pontuação do jogador for maior ou igual a 10, ele ganhará um laptop novo.
* Se a pontuação do jogador for exatamente 7, ele ganhará uma viagem.
* Caso contrário, ganhará um gatinho.
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

Console.WriteLine($"Total = {total}");

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

Console.WriteLine();

/*
*   Desafio: aprimorar a taxa de renovação de assinaturas
*   Foi solicitado que você adicionasse um recurso ao software de sua empresa. 
*   O recurso destina-se a melhorar a taxa de renovação das assinaturas do software. 
*   Sua tarefa é exibir uma mensagem de renovação quando um usuário fizer logon no 
*   sistema de software e receber a notificação de que a assinatura está prestes a ser encerrada. 
*   Você precisará adicionar um par de instruções de decisão para adicionar corretamente a 
*   lógica de ramificação ao aplicativo para atender aos requisitos.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}