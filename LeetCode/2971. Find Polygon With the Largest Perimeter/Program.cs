// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine(LargestPerimeter([5, 5, 5]));
Console.WriteLine(LargestPerimeter([1, 12, 1, 2, 5, 50, 3]));
Console.WriteLine(LargestPerimeter([5, 5, 50]));
Console.WriteLine(LargestPerimeter([300005055, 352368231, 311935527, 315829776, 327065463, 388851949, 319541150, 397875604, 311309167, 391897750, 366860048, 359976490, 325522439, 390648914, 359891976, 369105322, 350430086, 398592583, 354559219, 372400239, 344759294, 379931363, 308829137, 335032174, 336962933, 380797651, 378305476, 336617902, 393487098, 301391791, 394314232, 387440261, 316040738, 388074503, 396614889, 331609633, 374723367, 380418460, 349845809, 318514711, 308782485, 308291996, 375362898, 397542455, 397628325, 392446446, 368662132, 378781533, 372327607, 378737987]));


long LargestPerimeter(int[] nums)
{
    var sortedArray = nums.OrderBy(x => x).Select(x => (long)x).ToArray();

    if (sortedArray.Length < 3) return -1;
    Console.WriteLine(sortedArray.Print());
    var result = new long[sortedArray.Length];
    result[0] = -1;
    for (int i = 1; i < sortedArray.Length; i++)
    {
        if (sortedArray[i - 1] <= sortedArray[i])
        {
            sortedArray[i] = sortedArray[i - 1] + sortedArray[i];
            result[i] = -1;
        }
        else
        {
            sortedArray[i] = sortedArray[i - 1] + sortedArray[i];
            result[i] = sortedArray[i];
        }


    }
    Console.WriteLine(sortedArray.Print());
    Console.WriteLine(result.Print());

   
    return result.Max();
}

