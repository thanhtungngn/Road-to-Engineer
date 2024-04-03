// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine(MaxSubarrayLength(nums: [1, 1, 1, 1, 2], k: 2));
Console.WriteLine(MaxSubarrayLength(nums: [3, 1, 1], k: 1));

Console.WriteLine(MaxSubarrayLength(nums: [1, 2, 3, 1, 2, 3, 1, 2], k: 2));
Console.WriteLine(MaxSubarrayLength(nums: [1, 2, 1, 2, 1, 2, 1, 2], k: 1));
Console.WriteLine(MaxSubarrayLength(nums: [5, 5, 5, 5, 5, 5, 5], k: 4));

int MaxSubarrayLength(int[] nums, int k)
{
    var n = nums.Length;
    var result = 0;

    var end = 0;
    var freq = new Dictionary<int, int>();
    var subLength = 0;

    for (int i = 0; i < n; i++)
    {

        while (end < n)
        {

            if (freq.ContainsKey(nums[end]))
            {

                if (freq[nums[end]] == k)
                {
                    freq[nums[i]]--;
                    if (subLength > result)
                    {
                        result = subLength;
                    }
                    subLength--;
                    break;
                }
                else
                {
                    freq[nums[end]]++;
                   
                }

            }
            else
            {
                freq.Add(nums[end], 1);
                
            }
            end++;
            subLength++;

        }

        if (subLength > result)
        {
            result = subLength;
        }
    }
    return result;
}