// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(KidsWithCandies([2,3,5,1,3], 3));
Console.WriteLine(KidsWithCandies([4, 2, 1, 1, 2], 1));
Console.WriteLine(KidsWithCandies([12, 1, 12], 10));


IList<bool> KidsWithCandies(int[] candies, int extraCandies)
{
    List<bool> result = new List<bool>();
    var max = candies.Max();
    foreach (var item in candies)
    {
        if(item + extraCandies >= max)
        {
            result.Add(true);
        }
        else
        {
            result.Add(false);
        }
    }
    return result;
}