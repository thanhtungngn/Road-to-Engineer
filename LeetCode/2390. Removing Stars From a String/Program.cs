// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(RemoveStars("leet**cod*e"));
Console.WriteLine(RemoveStars("erase*****"));
Console.WriteLine(RemoveStars("abb*cdfg*****x*"));
string RemoveStars(string s)
{
    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        if (c == '*' && stack.Count > 0)
        {
            stack.Pop();
        }
        else
        {
            stack.Push(c);

        }
    }

    char[] output = new char[stack.Count()];
    for (int i = (output.Length - 1); i >= 0; i--)
    {
        output[i] = stack.Pop();
    }
    return new string(output);
}
