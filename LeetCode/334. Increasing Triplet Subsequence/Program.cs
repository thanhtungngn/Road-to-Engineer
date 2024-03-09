// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(IncreasingTriplet([1, 2, 3, 4, 5]));
Console.WriteLine(IncreasingTriplet([5, 4, 3, 2, 1]));
Console.WriteLine(IncreasingTriplet([2, 1, 5, 0, 4, 6]));

bool IncreasingTriplet(int[] nums)
{
    var orderedArray = nums.OrderBy(x => x).Distinct().ToArray();

    if(orderedArray.Length < 3)
    {
        return false;
    }

    var index = 0;
    while (index < orderedArray.Length)
    {
        var indexMin = Array.IndexOf(nums, orderedArray[index]);
        var indexAvg = 0;
        for (var i = indexMin+1; i < nums.Length; i++)
        {
            if (nums[i] > orderedArray[index])
            {
                for (indexAvg = i + 1; indexAvg < nums.Length; indexAvg++)
                {
                    if (nums[indexAvg] > nums[i])
                    {
                        return true;
                    }
                }
            }
        }
        index ++;
    }
    return false;

}