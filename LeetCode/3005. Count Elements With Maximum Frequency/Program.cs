// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(MaxFrequencyElements([1, 2, 2, 3, 1, 4]));
Console.WriteLine(MaxFrequencyElements([1, 2, 3, 4, 5]));

int MaxFrequencyElements(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (dict.ContainsKey(nums[i]))
        {
            dict[nums[i]]++;
        }
        else
        {
            dict.Add(nums[i], 1);
        }
    }
    dict = dict.OrderByDescending(x => x.Value).ToDictionary();
    var result = dict.Where(x => x.Value == dict.FirstOrDefault().Value).Sum(x => x.Value);
    return result;
}