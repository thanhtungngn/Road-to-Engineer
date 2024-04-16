// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine("Hello, World!");

void MoveZeroes(int[] nums)
{
    var currentIndex = 0;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == 0 && nums[currentIndex] != 0)
        {
            currentIndex = i;
        }
        else if (nums[i] != 0 && nums[currentIndex] == 0) 
        {
            nums[currentIndex] = nums[i];
            nums[i] = 0;
            currentIndex ++;
        }
        else
        {
            //currentIndex++;
        }
    }
}

var nums = new int[]{ 0, 1, 0, 3, 12, 0, 10 };
MoveZeroes(nums);
Console.WriteLine(nums.Print());