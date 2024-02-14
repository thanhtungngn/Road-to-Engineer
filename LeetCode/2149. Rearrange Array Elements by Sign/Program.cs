// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

using Common;
Console.WriteLine(RearrangeArray([3, 1, -2, -5, 2, -4]).Print());
Console.WriteLine(RearrangeArray([1,-1]).Print());


int[] RearrangeArray(int[] nums)
{
    int[] result = new int[nums.Length];

    int lastNumber = nums[0];
    int posIndex = 0;
    int negIndex = 1;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
        {
            result[posIndex] = nums[i];
            posIndex += 2;
        }
        else
        {
            result[negIndex] = nums[i];
            negIndex += 2;
        }
    }


    return result;
}