// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(MinimumLength("abbbbbbbbbbbbbbbbbbba"));
Console.WriteLine(MinimumLength("bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb"));
Console.WriteLine(MinimumLength("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbacccabbabccaccbacaaccacacccaccbbbacaabbccbbcbcbcacacccccccbcbbabccaacaabacbbaccccbabbcbccccaccacaccbcbbcbcccabaaaabbbbbbbbbbbbbbb"));

int MinimumLength(string s)
{
    int length = s.Length;
    int lastIndex = s.Length - 1;
    char lastRemoval = ' ';
    if(length <=1)
    {
        return length;
    }
    var i = 0;
    while(i<=lastIndex)
    {
       
        if (s[i] == lastRemoval)
        {
            length--;
            i++;
        }
        else if (s[lastIndex] == lastRemoval) {
            length--;
            lastIndex--;
        }
        else if (s[i] == s[lastIndex] ) {
            if (i == lastIndex)
            {
                return length;
            }
            lastRemoval = s[lastIndex];
            lastIndex--;
            length -= 2;
            i++;
        }  
        else
        {
            return length;
        }
    }
    return length;
}