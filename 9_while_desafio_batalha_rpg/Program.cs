
Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int diceValue;

while (heroHealth > 0 && monsterHealth > 0)
{
    diceValue = random.Next(1, 11);
    monsterHealth -= diceValue;
    System.Console.WriteLine($"Monster lost {diceValue} HP, current Monster HP: {monsterHealth}");
    if (monsterHealth > 0){
        diceValue = random.Next(1, 11);
        heroHealth -= diceValue;
        System.Console.WriteLine($"Hero lost {diceValue} HP, current Hero HP: {heroHealth}");
    }
    
}
if (heroHealth > monsterHealth){
    Console.WriteLine("Hero Won!");
}else{
    Console.WriteLine("Monster Won!");
}