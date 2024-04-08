// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(CheckValidString("()"));
//Console.WriteLine(CheckValidString("(*)"));
Console.WriteLine(CheckValidString("(((((*(()((((*((**(((()()*)()()()*((((**)())*)*)))))))(())(()))())((*()()(((()((()*(())*(()**)()(())"));
//Console.WriteLine(CheckValidString("((((()(()()()*()(((((*)()*(**(())))))(())()())(((())())())))))))(((((())*)))()))(()((*()*(*)))(*)()"));

bool CheckValidString(string s)
{
    var count = 0;
    var stack = new Stack<char>();



    for (int i = 0; i < s.Length; i++ )
    {
        if(s[i] == '*') { count++; }
        else if (s[i] == '(')
        {
            stack.Push(s[i]);
        }
        else if (s[i] == ')')
        {
            if(stack.Count > 0)
            {
                stack.Pop();
            }
            else
            {
                if(count <= 0)
                {
                    return false;
                }
                else
                {
                    count--;
                }
            }
        }
    }
    if( stack.Count > 0 )
    {
        if(stack.Count > count ) {
            return false;
        }

    }

    return true;
}

