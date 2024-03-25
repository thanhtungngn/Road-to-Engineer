// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


IList<int> FindDuplicates(int[] nums)
{
    var result = new List<int>();
    Array.Sort(nums);
    for (int i = 0; i < nums.Length-1; i++)
    {
        if (nums[i + 1] == nums[i])
        {
            result.Add(nums[i]);
            i++;
        }
    }
    return result;
}