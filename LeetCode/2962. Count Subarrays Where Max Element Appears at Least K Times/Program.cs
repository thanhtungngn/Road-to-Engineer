// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

//Console.WriteLine(CountSubarrays(nums: [1, 3, 2, 3, 3], k: 2));
Console.WriteLine(CountSubarrays(nums: [61, 23, 38, 23, 56, 40, 82, 56, 82, 82, 82, 70, 8, 69, 8, 7, 19, 14, 58, 42, 82, 10, 82, 78, 15, 82], k: 2));

long CountSubarrays(int[] nums, int k)
{
    var result = 0;

    var n = nums.Length;
    var end = 0;
    var freq = new Dictionary<int, int>();

    for (int start = 0; start < n; start++)
    {
        while (end < n)
        {
            if (freq.ContainsKey(nums[end]))
            {
                freq[nums[end]]++;

                if (freq[nums[end]] == k)
                {
                    result += n - end;
                    freq[nums[end]]--;

                    break;
                }
            }
            else
            {
                freq.Add(nums[end], 1);
            }
            end++;

        }
        freq[nums[start]]--;
    }

    return result;
}