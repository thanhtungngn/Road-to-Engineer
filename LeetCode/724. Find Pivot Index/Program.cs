// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(PivotIndex([-1, -1, -1, -1, -1, 0]));

int PivotIndex(int[] nums)
{
    var result = 0;
    var index = 0;
    var sum = nums.Sum();
    var (sumLeft, sumRight) = (0, sum);
    
    while(index < nums.Length)
    {

        sumRight -= nums[index];
        if(sumLeft == sumRight)
        {
            return index;
        }
        sumLeft += nums[index];

        index++;
    }
    return -1;
}