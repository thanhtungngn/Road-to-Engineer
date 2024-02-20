// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine(MissingNumber([3, 0, 1]));
Console.WriteLine(MissingNumber([0, 1]));
Console.WriteLine(MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]));

int MissingNumber(int[] nums)
{
    int n = nums.Length;
    int expectedSum = (n-1)*n/2;
    for (int i = 0; i < n; i ++)
    {
        expectedSum -= nums[i]; 
    }
    return expectedSum + n;
}