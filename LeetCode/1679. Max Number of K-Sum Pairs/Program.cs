// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");

Console.WriteLine(MaxOperations(nums: [3, 1, 3, 4, 3], k: 6));
Console.WriteLine(MaxOperations(nums: [4, 4, 1, 3, 1, 3, 2, 2, 5, 5, 1, 5, 2, 1, 2, 3, 5, 4], k: 2));
Console.WriteLine(MaxOperations(nums: [2, 2, 2, 3, 1, 1, 4, 1], k: 4));

int MaxOperations(int[] nums, int k)
{
    Array.Sort(nums);
    var result = 0;
    var startIndex = 0;
    var missing = k - nums[startIndex];
    var endIndex = nums.Length - 1;
    while (endIndex > startIndex && startIndex < nums.Length && endIndex >= 0)
    {
        missing = k - nums[startIndex];

        if (missing <= 0)
        {
            return result;
        }

        if (nums[endIndex] > missing)
        {
            endIndex--;
        }
        else if (nums[endIndex] == missing)
        {

            endIndex--;

            startIndex++;

            result++;
        }
        else
        {
            startIndex++;
        }
    }
    return result;
}