// See https://aka.ms/new-console-template for more information
Console.WriteLine(FindLeastNumOfUniqueInts([5, 5, 4],1));
Console.WriteLine(FindLeastNumOfUniqueInts([4, 3, 1, 1, 3, 3, 2], 3));


int FindLeastNumOfUniqueInts(int[] arr, int k)
{
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (dict.ContainsKey(arr[i]))
        {
            dict[arr[i]]++;
        }
        else
        {
            dict.Add(arr[i], 1);
        }
    }
    var sortedDict = dict.OrderBy(x => x.Value).ToDictionary();
    foreach (var kvp in sortedDict)
    {
        if (kvp.Value > k)
        {
            return sortedDict.Count;
        }
        else
        {
            k = k - kvp.Value;
            sortedDict.Remove(kvp.Key);
        }
    }
    return sortedDict.Count;
}