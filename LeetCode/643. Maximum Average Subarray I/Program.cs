// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Console.WriteLine(FindMaxAverage(nums: [1, 12, -5, -6, 50, 3], k: 4));
Console.WriteLine(FindMaxAverage(nums: [0, 1, 1, 3, 3], k: 4));

double FindMaxAverage(int[] nums, int k)
{
    double total = 0;
    var n = nums.Length;
    for (int i = 0; i < k; i++)
    {
        total += nums[i];
    }
    double max = total / k;
    var index = 1;
    while (index <= nums.Length - k)
    {
        total = total - nums[index-1] + nums[index+k-1];
        double avg = total/ k;
        if (avg > max)
        {
            max = avg;
        }
        index++;
    }

    return max;
}