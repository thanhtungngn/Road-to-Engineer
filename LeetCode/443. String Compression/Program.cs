// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine(Compress(chars : ['a', 'a', 'b', 'b', 'c', 'c', 'c']));
Console.WriteLine(Compress(chars : ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b']));
Console.WriteLine(Compress(chars : ['a', 'a', 'a', 'b', 'b', 'a', 'a']));


int Compress(char[] chars)
{
    var result = 1;
    var count = 1;
    var lastCharIndex = 0;
    for (int i = 1; i < chars.Length; i++)
    {
        if (chars[i] == chars[lastCharIndex])
        {
            chars[i]= ' ';
            count++;
        }
        else
        {
            if(count > 1)
            {
                if (count < 10)
                {
                    chars[lastCharIndex + 1] = (count.ToString()[0]);
                    result++;
                    lastCharIndex += 1;
                }
                else
                {
                    var number = count.ToString();
                    for (int j = 0; j < number.Length; j++)
                    {
                        chars[lastCharIndex + 1 + j] = number[j];
                    }
                    result += number.Length;
                    lastCharIndex += number.Length;
                }
                
            }
            lastCharIndex += 1;
            chars[lastCharIndex] = chars[i]; 
            count = 1;
            result++;
        }

        if(i == chars.Length-1)
        {
            if( i != lastCharIndex && count > 1)
            {
                if (count < 10)
                {
                    chars[lastCharIndex + 1] = (count.ToString()[0]);
                    result++;
                }
                else
                {
                    var number = count.ToString();
                    for (int j = 0; j < number.Length; j++)
                    {
                        chars[lastCharIndex + 1 + j] = number[j];
                    }
                    result += number.Length;
                }
            }
        }
    }
   
   

    Console.WriteLine(chars.Print());
    return result;
}