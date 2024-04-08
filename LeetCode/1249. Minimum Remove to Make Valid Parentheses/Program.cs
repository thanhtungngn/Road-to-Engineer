// See https://aka.ms/new-console-template for more information
using System.Text;

//Console.WriteLine("Hello, World!");
//Console.WriteLine(MinRemoveToMakeValid("lee(t(c)o)de)"));
//Console.WriteLine(MinRemoveToMakeValid("a)b(c)d"));
Console.WriteLine(MinRemoveToMakeValid("))(("));


string MinRemoveToMakeValid(string s)
{
    Stack<(char, int)> stack = new Stack<(char, int)>();
    var result = new StringBuilder();

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];
        if (c == '(')
        {
            result.Append(c);
            stack.Push((c, result.Length-1));

        }
        else if (c == ')')
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                result.Append(c);
                
            }
        }
        else
        {
            result.Append(c);
        }
    }

    while (stack.Count > 0)
    {
        result.Remove(stack.Pop().Item2,1);
    }



    return result.ToString();
}