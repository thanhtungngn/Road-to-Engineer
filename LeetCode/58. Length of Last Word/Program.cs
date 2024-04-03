// See https://aka.ms/new-console-template for more information
Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));

int LengthOfLastWord(string s)
{
    var words = s.Split(' ');
    return words[words.Length - 1].Length;
}