// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int MaxDepth(string s)
{
    var result = 0;
    var stack = new Stack<char>();
    var current = 0;
    for (int i = 0; i< s.Length; i++)
    {
        if (s[i] == '(')
        {
            stack.Push(s[i]);
            current++;
        }
        if (s[i] == ')' && stack.Count >0)
        {
            stack.Pop();
            if(result < current)
            {
                result = current;
            }
            current--;
        }
    }
    return result;
}