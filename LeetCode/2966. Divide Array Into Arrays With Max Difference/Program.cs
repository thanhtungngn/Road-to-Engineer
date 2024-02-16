// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine(DivideArray([15, 13, 12, 13, 12, 14, 12, 2, 3, 13, 12, 14, 14, 13, 5, 12, 12, 2, 13, 2, 2], 2).Print());
//Console.WriteLine(DivideArray([1, 3, 3, 2, 7, 3], 3).Print());

int[][] DivideArray(int[] nums, int k)
{
    int[][] result = new int[nums.Length/3][];
    Array.Sort(nums);

    var index = 0;

    for (int i = 0; i < nums.Length; i = i+3)
    {
        if (nums[i+1] - nums[i] <= k 
            && nums[i+2] - nums[i+1] <= k
            && nums[i+2] - nums[i] <= k)
        {
            result[index] = [nums[i], nums[i + 1], nums[i + 2]];
            index++;
        }
        else
        {
            return [];
        }
    }
    return result;
    
}