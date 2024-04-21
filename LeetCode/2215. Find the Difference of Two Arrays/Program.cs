// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
{
    HashSet<int> set1 = new HashSet<int>();
    HashSet<int> set2 = new HashSet<int>();
    foreach (int i in nums1)
    {
        if (!nums2.Contains(i))
        {
            set1.Add(i);
        }
    }
    foreach (int i in nums2)
    {
        if (!nums1.Contains(i))
        {
            set2.Add(i);
        }
    }
    IList<IList<int>> result = new List<IList<int>>() { set1.ToList(), set2.ToList()};
    return result;
}