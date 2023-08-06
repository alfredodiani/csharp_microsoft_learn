/*
*       Arrays e métodos auxiliares
*/

/*
    Array.Sort
*/
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);                //método para ordenar itens
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");


/*
    Array.Reverse
*/
Console.WriteLine("Reversed...");
Array.Reverse(pallets);             //método para inverter a ordem atual dos itens
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");


/*
    Array.Clear

    Removerá a referência de um elemento da matriz a um valor, apontando para null
*/
string[] pallets2 = { "B14", "A11", "B12", "A13" };

Console.WriteLine($"Before: {pallets2[0]}");
Array.Clear(pallets2, 0, 2);                 //limpa 2 itens do array a partir da posição 0 (nesse caso os 2 primeiros elementos)
Console.WriteLine($"After: {pallets2[0]}");
      
Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");
foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");


/*
    Array.Resize
*/
Array.Resize(ref pallets2, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets2.Length}");

pallets2[4] = "C01";
pallets2[5] = "C02";

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}


/*
    É possível remover elementos nulos de uma matriz?
    
    Se o método Array.Resize() não remover elementos vazios de uma matriz, 
    há algum outro método auxiliar que faz isso automaticamente? 
    
    Não. A melhor maneira de esvaziar os elementos de uma matriz é contar 
    o número de elementos não nulos percorrendo cada item e incrementando 
    uma variável (contador). Em seguida, você criará uma segunda matriz que 
    tem o tamanho da variável do contador. Por fim, você executará um loop 
    em cada elemento na matriz original e copiará valores não nulos na nova 
    matriz.
*/
