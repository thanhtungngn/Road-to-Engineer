// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine("Hello, World!");
Console.WriteLine(TwoSum([2, 7, 11, 15],9).Print());
Console.WriteLine(TwoSum([3, 2, 4],6).Print());
Console.WriteLine(TwoSum([3, 3],6).Print());

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        var x = target - nums[i];
        var index = Array.IndexOf(nums, x);
        if(index != -1 && index != i)
        {
            return new int[] { i, index };
        }
    }
    return new int[2];
}