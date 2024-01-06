string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string sentense = "there are snakes at the zoo";

Console.WriteLine(sentense);
Console.WriteLine(ReverseSentence(sentense));

string ReverseWord(string word) 
{
    string result = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach (var word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
    
}