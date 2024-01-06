int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

//second example
int target2 = 30;
int[] coins2 = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result2 = TwoCoinsChanges(coins2, target2);

if (result2.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result2.GetLength(0); i++) 
    {
        if (result2[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result2[i,0]},{result2[i,1]}");
    }
}

int[] TwoCoins(int[] coins, int target) 
{
    for (int coin1 = 0; coin1 < coins.Length; coin1++)
    {
        for (int coin2 = coin1 + 1; coin2 < coins.Length; coin2++)
        {
            if (coins[coin1] + coins[coin2] == target)
                return new int[]{coin1, coin2};
            
        }
    }
    return  new int[0];
}

//returns 0 to 5 pairs of coins that meets the target
int[,] TwoCoinsChanges(int[] coins, int target)
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}