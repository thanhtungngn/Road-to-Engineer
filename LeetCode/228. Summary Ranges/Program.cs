// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine(SummaryRanges([0, 2, 3, 4, 6, 8, 9]).Print());

IList<string> SummaryRanges(int[] nums)
{
    var result = new List<string>();
    if (nums.Length == 0)
    {
        return new List<string>();
    }
    var step = 0;
    var currentText = $"{nums[0]}";
    for (int i = 1; i < nums.Length; i++)
    {
        if (string.IsNullOrEmpty(currentText))
        {
            currentText += nums[i];
        }
        else
        {
            if (nums[i] - nums[i - 1] != 1 && step > 0)
            {
                currentText += $"->{nums[i-1]}";
                result.Add(currentText);
                currentText = $"{nums[i]}";
                step = 0;
            }
            else if (nums[i] - nums[i-1] == 1)
            {
                step++;
            }
            else
            {
                result.Add(currentText);
                currentText = $"{nums[i]}";
            }
        }

    }

    if(step > 0)
    {
        currentText += $"->{nums[nums.Length-1]}";
        result.Add(currentText);
    }
    else
    {
        result.Add(currentText);
    }
    return result;
}