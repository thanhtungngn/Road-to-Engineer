// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine(ReverseWords("the sky is blue"));
Console.WriteLine(ReverseWords("  hello world  "));
Console.WriteLine(ReverseWords("a good   example"));


string ReverseWords(string s)
{
    var splittedWords = s.Trim().Split(' ');

    var result = new StringBuilder();
    for (int i = splittedWords.Length-1; i >=0 ; i--)
    {
        if (!String.IsNullOrEmpty(splittedWords[i]))
        {
            result.Append(splittedWords[i]);
            result.Append(' ');
        }
        
    }
    result.Remove(result.Length-1, 1);
    return result.ToString();
}
