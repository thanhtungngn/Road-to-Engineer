// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int NumSubarrayProductLessThanK(int[] nums, int k)
{
    int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        var product = nums[i];
        if (product < k)
        {
            count++;
            for (int j = i + 1; j < nums.Length; j++)
            {
                product = product * nums[j];
                if (product >= k)
                {
                    break;
                }
                count++;
            }
        }
    }

    return count;
}