// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(IsIsomorphic("badc", "baba"));

bool IsIsomorphic(string s, string t)
{
    Dictionary<char, char> d = new Dictionary<char, char>();
    Dictionary<char, char> dict = new Dictionary<char, char>();


    for (int i = 0; i < s.Length; i++)
    {
        if (!d.ContainsKey(s[i]) && !dict.ContainsKey(t[i]))
        {
            d.Add(s[i], t[i]);
            dict.Add(t[i], s[i]);
        }
        else if ((d.ContainsKey(s[i]) && !dict.ContainsKey(t[i]) || (dict.ContainsKey(t[i]) && !d.ContainsKey(s[i]))))
        {
            return false;
        }
        else
        {
            if (t[i] != d[s[i]] || s[i] != dict[t[i]])
            {
                return false;
            }
        }
    }
    return true;
}
