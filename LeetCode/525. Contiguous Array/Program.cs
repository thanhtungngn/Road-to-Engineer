// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(FindMaxLength([0, 0, 0, 1, 1, 1, 0]));
Console.WriteLine(FindMaxLength([0, 1, 0]));

int FindMaxLength(int[] nums)
{
    Dictionary<int, int> countMap = new Dictionary<int, int>();
    int maxLength = 0;
    int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        count += nums[i] == 1 ? 1 : -1;

        if (count == 0)
            maxLength = i + 1;

        if (countMap.ContainsKey(count))
            maxLength = Math.Max(maxLength, i - countMap[count]);
        else
            countMap[count] = i;
    }

    return maxLength;

}