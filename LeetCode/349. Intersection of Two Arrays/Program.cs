// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(Intersection([1, 2, 2, 1], [2, 2]));
Console.WriteLine(Intersection([4, 9, 5], [9, 4, 9, 8, 4]));

int[] Intersection(int[] nums1, int[] nums2)
{
    var result = new List<int>();
    if(nums1.Length < nums2.Length)
    {
        for(int i = 0; i < nums1.Length; i++) {
            if (nums2.Contains(nums1[i]) && !result.Contains(nums1[i]))
            {
                result.Add(nums1[i]);
            }
        }
    }
    else
    {
        for (int i = 0; i < nums2.Length; i++)
        {
            if (nums1.Contains(nums2[i]) &&!result.Contains(nums2[i]))
            {
                result.Add(nums2[i]);
            }
        }
    }
    return result.ToArray();
}