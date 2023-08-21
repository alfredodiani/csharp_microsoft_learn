/*
    Example 1
    LastIndexOf
    Retrieve the last occurrence of a sub string
*/

string message_b = "(What if) I am (only interested) in the last (set of parentheses)?";

int openingPosition_b = message_b.LastIndexOf('(');
openingPosition_b += 1;

int closingPosition_b = message_b.LastIndexOf(')');

int length_b = closingPosition_b - openingPosition_b;
Console.WriteLine(message_b.Substring(openingPosition_b, length_b));


/*
    Example 2
    Retrieve all instances of substrings inside parentheses
*/

string message_a = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition_a = message_a.IndexOf('(');
    if (openingPosition_a == -1) 
        break;

    openingPosition_a += 1;
    int closingPosition_a = message_a.IndexOf(')');
    int length_a = closingPosition_a - openingPosition_a;
    Console.WriteLine(message_a.Substring(openingPosition_a, length_a));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message_a = message_a.Substring(closingPosition_a + 1);
}


/*
    Example 3
    Work with different types of symbol sets
*/

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
// next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) 
    {
        break;
    }

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}