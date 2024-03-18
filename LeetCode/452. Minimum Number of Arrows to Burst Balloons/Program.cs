// See https://aka.ms/new-console-template for more information
Console.WriteLine(FindMinArrowShots([[10, 16], [2, 8], [1, 6], [7, 12]]));
Console.WriteLine(FindMinArrowShots([[1, 2], [3, 4], [5, 6], [7, 8]]));
Console.WriteLine(FindMinArrowShots([[1, 2], [2, 3], [3, 4], [4, 5]]));

int FindMinArrowShots(int[][] points)
{
    Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
    var result = 1;

    var common = points[0];

    for (int i = 1; i< points.Length; i++)
    {
        common = Intersect(common.ToArray(), points[i]);
        if(common != null)
        {
            continue;
        }
        else
        {
            result += 1;
            common = points[i];
        }
    }
    return result;

}

int[] Intersect(int[] arr1, int[] arr2)
{
    var result = new int[2];
    if (arr1[0] > arr2[0])
    {
        result[0] = arr1[0];
    }
    else
    {
        result[0] = arr2[0];
    }

    if (arr1[1] > arr2[1])
    {
        result[1] = arr2[1];
    }
    else
    {
        result[1] = arr1[1];
    }

    if (result[1] < result[0]) return null;
    return result;
}