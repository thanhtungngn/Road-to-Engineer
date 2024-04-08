// See https://aka.ms/new-console-template for more information
using System.Text;

//Console.WriteLine(MakeGood("leEeetcode"));
Console.WriteLine(MakeGood("abBAcC"));


string MakeGood(string s)
{
    var result = new StringBuilder();

    foreach (char c in s)
    {
        if (result.Length > 0 && Math.Abs(c - result[result.Length - 1]) == 32)
        {
            result.Length--; // Remove the last character if it forms a bad pair with the current character
        }
        else
        {
            result.Append(c); // Append the current character to the result
        }
    }
    return result.ToString();
}