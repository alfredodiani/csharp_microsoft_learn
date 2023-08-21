/*
    Example 1
    Remove
        Remove characters in specific locations from a string
*/

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


/*
    Example 2
    Replace
        Remove characters no matter where they appear in a string
*/

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);