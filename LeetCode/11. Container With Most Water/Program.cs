// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
int MaxArea(int[] height)
{
    //var max = 0;
    //for (int i = 0; i < height.Length; i++)
    //{
    //    for (int j = i + 1; j < height.Length; j++)
    //    {
    //        var amount = 0;
    //        if (height[j] > height[i])
    //        {
    //            amount = height[i] * (j - i);
    //        }
    //        else
    //        {
    //            amount = height[j] * (j - i);
    //        }
    //        max = Math.Max(max, amount);
    //    }
    //}
    //return max;

    var max = 0;
    var left = 0;
    var right = height.Length-1;
    while (left < right)
    {
        var amount = 0;
        if (height[left] < height[right])
        {
            amount = height[left] * (right-left);
            left++;
        }
        else
        {
            amount = height[right] * (right-left);
            right--;
        }
        max = Math.Max(max, amount);
    }
    return max;
}