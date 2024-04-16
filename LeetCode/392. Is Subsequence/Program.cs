// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(IsSubsequence(s: "c", t: "b"));

bool IsSubsequence(string s, string t)
{
    var sIndex = 0;
    var tIndex = 0;
    if(s.Length == 0)
    {
        return true;
    }
    if(t.Length == 0)
    {
        return false;
    }
    while(tIndex < t.Length)
    {
        if (t[tIndex] == s[sIndex])
        {
            sIndex++;
        }
        if(sIndex == s.Length)
        {
            return true;
        }
        tIndex++;
    }
    return sIndex == s.Length;
}