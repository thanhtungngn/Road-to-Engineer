// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine(CloseStrings(word1: "abbbzcf", word2: "babzzcz"));
Console.WriteLine(CloseStrings(word1: "abbzccca", word2: "babzzczc"));
Console.WriteLine(CloseStrings(word1: "uau", word2: "ssx"));
Console.WriteLine(CloseStrings(word1: "cabbba", word2: "abbccc"));
Console.WriteLine(CloseStrings(word1: "a", word2: "aa"));

bool CloseStrings(string word1, string word2)
{
    //Dictionary<char, List<char>> dict = new Dictionary<char, List<char>>();
    Dictionary<char, int> word1_freq = new Dictionary<char, int>();
    Dictionary<char, int> word2_freq = new Dictionary<char, int>();
    if (word1.Length != word2.Length)
    {
        return false;
    }

    for (int i = 0; i < word1.Length; i++)
    {
        var charWord1 = word1[i];
        var charWord2 = word2[i];
        //if (dict.ContainsKey(charWord1))
        //{
        //    dict[charWord1].Add(charWord2);
        //}
        //else
        //{
        //    dict.Add(charWord1, new List<char>() { charWord2 });
        //}

        if (word1_freq.ContainsKey(charWord1))
        {
            word1_freq[charWord1]++;
        }
        else
        {
            word1_freq.Add(charWord1, 1);
        }

        if (word2_freq.ContainsKey(charWord2))
        {
            word2_freq[charWord2]++;
        }
        else
        {
            word2_freq.Add(charWord2, 1);
        }
    }
    var usedChar = String.Empty;
    foreach (var item in word1_freq)
    {
        var isRepalcable = false;
        var sameOccurence = word2_freq.Where(x => x.Value == item.Value && !usedChar.Contains(x.Key));
        foreach (var character in sameOccurence)
        {
            if (word1_freq.ContainsKey(character.Key))
            {
                isRepalcable = true;
                usedChar += character.Key;
                break;

            }
        }
        if (!isRepalcable)
        {
            return false;
        }

    }
    return true;

}