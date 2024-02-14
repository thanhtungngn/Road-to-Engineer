// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine(ReverseVowels("hello"));
Console.WriteLine(ReverseVowels("leetcode"));
Console.WriteLine(ReverseVowels("a."));

// BETTER USING STACK + STRING BUILDER 

string ReverseVowels(string s)
{
    var result = new StringBuilder();
    var vowelStack = new Stack<char>();

    foreach (char c in s)
    {
        if ("aeiouAEIOU".Contains(c))
        {
            vowelStack.Push(c);
        }
    }

    foreach (char c in s) {
        if ("aeiouAEIOU".Contains(c))
        {
            result.Append(vowelStack.Pop());
        }
        else
        {
            result.Append(c);
        }
    }
    return result.ToString();
}
