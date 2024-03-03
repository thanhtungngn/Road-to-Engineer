// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine(MaximumOddBinaryNumber("010"));
Console.WriteLine(MaximumOddBinaryNumber("0101"));

string MaximumOddBinaryNumber(string s)
{
    var result = new StringBuilder();
    var stringLength = s.Length;
    var numberOf1 = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '1') { numberOf1++; }
    }

    if(numberOf1 == 1)
    {
        for (int i = 0;i < s.Length-1; i++)
        {
            result.Append('0');
        }
        result.Append('1');
    } 

    else
    {
        for (int i = 0; i < numberOf1-1; i++)
        {
            result.Append('1');
        }
        for(int i = 0; i< s.Length - numberOf1; i++)
        {
            result = result.Append('0');
        }
        result.Append('1');
    }
    return result.ToString();
}
