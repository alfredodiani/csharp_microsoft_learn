/*
Para promover os produtos de investimento mais recentes de uma empresa de marketing e vendas, 
você envia milhares de cartas personalizadas para os clientes existentes. Seu trabalho é escrever 
códigos em C# para mesclar informações personalizadas sobre o cliente. A carta conterá informações, 
como o portfólio existente, e comparará os retornos atuais com os projetados se o cliente investir 
no uso dos novos produtos.

Os escritores escolheram a seguinte mensagem de marketing de exemplo. 
Veja a saída desejada (usando dados fictícios da conta do cliente).

'''
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   $55,000,000.00      
Glorious Future     13.13 %   $63,000,000.00
123456789012345678
'''
*/

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string initialMessage = "";
initialMessage += $"Dear {customerName},\n";
initialMessage += $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n";
initialMessage += $"Currently, you own {currentShares:N} at a return of {currentReturn:P}\n";
initialMessage += $"Our new product {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}\n";

Console.WriteLine(initialMessage);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(18);
comparisonMessage += $"{currentReturn:P2}".PadLeft(8);
comparisonMessage += $"{currentProfit:C}".PadLeft(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(18);
comparisonMessage += $"{newReturn:P2}".PadLeft(8);
comparisonMessage += $"{newProfit:C}".PadLeft(20);

Console.WriteLine(comparisonMessage);