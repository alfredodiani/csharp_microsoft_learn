
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Numero da Cobrança: {invoiceNumber}");
Console.WriteLine($"   Ações: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Imposto: {taxPercentage:P2}");
Console.WriteLine($"     Total cobrança: {total:C}");

