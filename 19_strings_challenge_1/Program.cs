/*
    Challenge

*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string quantityTagInit = "<span>";
string quantityTagClose = "</span>";

int quantityBegining = input.IndexOf(quantityTagInit) + quantityTagInit.Length;
int quantityEnding = input.IndexOf(quantityTagClose);
int quantityLenght = quantityEnding - quantityBegining;

quantity = input.Substring(quantityBegining, quantityLenght);

int outputBegining = input.IndexOf("<div>") + "<div>".Length;
int outputEnding = input.IndexOf("</div>");
int outputLenght = outputEnding - outputBegining;

output = input.Substring(outputBegining, outputLenght);

output = output.Replace("&trade", "&reg");

Console.WriteLine(quantity);
Console.WriteLine(output);