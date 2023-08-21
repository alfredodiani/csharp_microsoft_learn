/*
    Example1
    Add code to retrieve the value between parenthesis
*/

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf("(");
int closingPosition = message.IndexOf(")");

Console.WriteLine(openingPosition + " " + closingPosition);

openingPosition += 1;
int lenght = closingPosition - openingPosition;
string insideParentheses = message.Substring(openingPosition, lenght);
Console.WriteLine(insideParentheses);


/*
    Example 2
    Modify the starting position of the sub string
*/

string message2 = "What is the value <span>between the tags</span>?";

int openingPosition2 = message2.IndexOf("<span>");
int closingPosition2 = message2.IndexOf("</span>");

openingPosition2 += 6;
int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2));

/*
    Example 3
    Avoid magic values
*/

string message3 = "What is the value <span>between the tags</span>?";

const string openSpan3 = "<span>";
const string closeSpan3 = "</span>";

int openingPosition3 = message3.IndexOf(openSpan3);
int closingPosition3 = message3.IndexOf(closeSpan3);

openingPosition3 += openSpan3.Length;
int length3 = closingPosition3 - openingPosition3;
Console.WriteLine(message3.Substring(openingPosition3, length3));