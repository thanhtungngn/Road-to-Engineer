// See https://aka.ms/new-console-template for more information
using Common;
using System.Runtime.InteropServices;
using System.Text;
Console.WriteLine(RangeBitwiseAnd(5,7));
Console.WriteLine(RangeBitwiseAnd(0,0));
Console.WriteLine(RangeBitwiseAnd(1,2147483647));


int RangeBitwiseAnd(int left, int right)
{
    var arrayLeft = ConvertIntToBitArray(left);
    var arrayRight = ConvertIntToBitArray(right);
    var commonArray = new int[arrayLeft.Length];
    for(int i = 0; i< arrayLeft.Length; i++)
    {
        if (arrayLeft[i] == arrayRight[i])
        {
            commonArray[i] = arrayLeft[i];
        }
        else
        {
            break;
        }
    }
    var result = 0;
    var pow = 31;
    for(int i = 0; i< commonArray.Length; i++)
    {
        if (commonArray[i] ==1 )
        {
            result += (int)Math.Pow(2, pow);
        }
        pow--;
    }

    return result;
}

int[] ConvertIntToBitArray(int num)
{
    int[] array = new int[32];
    var index = array.Length-1;
    while(num > 0)
    {
        array[index] = num % 2; 
        num /= 2;
        index--;
    }
    Console.WriteLine(array.Print());
    return array;
}