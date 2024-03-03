// See https://aka.ms/new-console-template for more information
using Common; 

Console.WriteLine("Hello, World!");

Console.WriteLine(SortedSquares([-4, -1, 0, 3, 10]).Print());
Console.WriteLine(SortedSquares([-7, -3, 2, 3, 11]).Print());

int[] SortedSquares(int[] nums)
{
    var result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = (int) Math.Pow(nums[i],2);
    }
    Array.Sort(result);  
    return result;
}