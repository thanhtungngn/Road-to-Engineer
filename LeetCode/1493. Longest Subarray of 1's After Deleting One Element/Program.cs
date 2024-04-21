// See https://aka.ms/new-console-template for more information
Console.WriteLine(LongestSubarray(nums: [1, 1, 0, 1]));
Console.WriteLine(LongestSubarray(nums: [0, 1, 1, 1, 0, 1, 1, 0, 1]));
Console.WriteLine(LongestSubarray(nums: [1, 1, 1]));
Console.WriteLine(LongestSubarray(nums: [1, 1, 0, 0, 1, 1, 1, 0, 1]));
Console.WriteLine(LongestSubarray(nums : [1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1]));
int LongestSubarray(int[] nums)
{
    var start = 0;
    var result = 0;
    var isDeleted = false;
    var count = 0;
    var isZeroFound = false;
    for (int end = 0; end < nums.Length; end++)
    {
        if (nums[end] ==1) { count++ ; }

        else
        {
            isZeroFound = true;
            if (end == 0 ) { start++; }
            else
            {
                if(!isDeleted)
                {
                    isDeleted = true;
                    start = end;
                }
                else
                {
                    count = end- start-1;
                    start = end;
                }
        
            }
        }

        if(count > result)
        {
            result = count;
        }
    }
    result = isZeroFound ? result : result-1;
    return result;
}