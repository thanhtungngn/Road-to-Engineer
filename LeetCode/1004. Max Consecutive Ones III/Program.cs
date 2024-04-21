// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine(LongestOnes(nums: [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], k: 2));
Console.WriteLine(LongestOnes(nums: [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], k: 3));
Console.WriteLine(LongestOnes(nums : [0, 0, 1, 1, 1, 0, 0], k : 0));

int LongestOnes(int[] nums, int k)
{
    var result = 0;
    var lastZeroIndexes=  new int[k];
    var i = 0;
    var endIndex = 0;
    var count = 0;
    var lastDeletedIndex = 0;
    while (endIndex<nums.Length)
    {
        if (nums[endIndex] == 1)
        {
            count++;
        } 
        else
        {
            if(lastZeroIndexes.Length == 0)
            {
                count = 0;
            }
            else
            {
                if (k == 0)
                {
                    var numberOfRemove = (lastZeroIndexes[i] - lastDeletedIndex) + 1;
                    if (lastZeroIndexes[i] == 0) { numberOfRemove = 1; }
                    count = count - (numberOfRemove);
                    lastDeletedIndex = ++lastZeroIndexes[i];
                }

                else
                {
                    k--;
                }
                lastZeroIndexes[i] = endIndex;
                count++;
                i++;
                if (i == lastZeroIndexes.Length)
                {
                    i = 0;
                }
            }
           
        }

        if (count > result)
        {
            result = count;
        }
        endIndex++;
    }

    return result;
}