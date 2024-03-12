// See https://aka.ms/new-console-template for more information
using System.Text;

//Console.WriteLine("Hello, World!");
//Console.WriteLine(CustomSortString("cba", "abcd"));
//Console.WriteLine(CustomSortString("bcafg", "abcd"));
Console.WriteLine(CustomSortString("kqep", "pekeq"));

string CustomSortString(string order, string s)
{
    var orderString = new char[s.Length];
    var index = s.Length - 1;
    var startIndex = 0;
    foreach (char c in s)
    {
        if (order.IndexOf(c) != -1)
        {
            if (startIndex == 0)
            {
                orderString[startIndex] = c;
                startIndex++;
            }
            else
            {
                if(order.IndexOf(c) > order.IndexOf(orderString[startIndex-1])) {
                    orderString[startIndex] = c;
                    startIndex++;
                }
                else
                {
                    var k = startIndex-1; 
                    while(k >=0)
                    {
                        if(order.IndexOf(c) < order.IndexOf(orderString[k]))
                        {
                            orderString[k + 1] = orderString[k];
                            k--;
                        }
                        else
                        {
                            orderString[k+1] = c;    
                            break; 
                        }

                        if (k == -1)
                        {
                            orderString[0] = c;
                        }
                    }

         
                    startIndex++;
                }
            }
        }
        else
        {
            orderString[index] = c;
            index--;
        }
    }

    var result = new StringBuilder();
    for (int i = 0; i<orderString.Length; i++)
    {
        result.Append(orderString[i]);
    }

    return result.ToString();
}
