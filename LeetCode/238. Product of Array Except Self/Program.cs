using Common;
// See https://aka.ms/new-console-template for more information
Console.WriteLine(ProductExceptSelf([1, 2, 3, 4]).Print());
Console.WriteLine(ProductExceptSelf([-1, 1, 0, -3, 3]).Print());


int[] ProductExceptSelf(int[] nums)
{
    var left = new int[nums.Length+1];
    var right = new int[nums.Length+1];

    for (int i = 0; i < nums.Length; i++)
    {
        if(i == 0)
        {
            left[i] = 1;
        }
        else
        {
            left[i] = left[i-1] * nums[i-1];
        }
    }
    Console.WriteLine(left.Print());

    for (int i = nums.Length-1; i >= 0; i--)
    {
        if (i == nums.Length-1)
        {
            right[i] = 1;
        }
        else
        {
            right[i] = right[i + 1] * nums[i+1];
        }
    }
    Console.WriteLine(right.Print());


    var result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = left[i]* right[i];
    }

    return result;
}