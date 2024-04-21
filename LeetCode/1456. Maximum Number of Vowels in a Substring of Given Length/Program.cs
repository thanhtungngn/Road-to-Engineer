// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine(MaxVowels(s: "abciiidef", k: 3));
Console.WriteLine(MaxVowels(s: "aeiou", k: 2));

Console.WriteLine(MaxVowels(s: "weallloveyou", k: 7));
int MaxVowels(string s, int k)
{
    var result = 0;
    var slowIndex = 1;
    char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

    for (int i = 0; i < k; i++)
    {
        if (vowel.Contains(s[i]))
        {
            result++;
        }
    }
    var count = result;
    while(slowIndex <= s.Length-k)
    {
        if (vowel.Contains(s[slowIndex+k-1]))
        {
            count++;
        }
        if (vowel.Contains(s[slowIndex-1]))
        {
            count--;
        }
        if(count > result)
        {
            result = count;
        }
        slowIndex++;
    }


    return result;
}