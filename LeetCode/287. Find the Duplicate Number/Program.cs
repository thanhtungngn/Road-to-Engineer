// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int FindDuplicate(int[] nums)
{
    var result = new int[nums.Length - 1];
    for (int i = 0; i < nums.Length; i++)
    {
        if (result[nums[i]-1] != 0)
        {
            return nums[i];
        }
        result[nums[i]-1] = nums[i]; 
    }
    return -1;
}