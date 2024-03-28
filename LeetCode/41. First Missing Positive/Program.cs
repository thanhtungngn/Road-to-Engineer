// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int FirstMissingPositive(int[] nums)
{
	// nlogn - medium
	Array.Sort(nums);
	var missing = 1;
	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] > 0)
		{
			if (nums[i] < missing)
			{
				continue;
			}
			else if (nums[i] == missing)
			{
				missing++;
			}
			else
			{
                return missing;

            }
        }
	}
	return missing;
}