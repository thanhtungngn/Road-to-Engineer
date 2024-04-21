// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(UniqueOccurrences([1, 2]));

bool UniqueOccurrences(int[] arr)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
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
    var orderDict = dict.OrderBy(x => x.Value);
    var dictCount = orderDict.Count();
    if(dictCount <= 1)
    {
        return true;
    }
    var lastCount = 0;
    foreach( var item in orderDict)
    {
        if(item.Value == lastCount)
        {
            return false;
        }
        lastCount = item.Value;
    }
    return true;
}