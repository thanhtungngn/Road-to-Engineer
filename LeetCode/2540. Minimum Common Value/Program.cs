// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(GetCommon([1, 2, 3], [2, 4]));
Console.WriteLine(GetCommon([1, 2, 3, 6], [2, 3, 4, 5]));
Console.WriteLine(GetCommon([3,5], [2]));

int GetCommon(int[] nums1, int[] nums2)
{
    int index1 = 0;
    int index2= 0;

    while(index1 < nums1.Length)
    {
        var num1 = nums1[index1];
        while(index2 < nums2.Length) {
            if (nums2[index2] < num1)
            {
                index2++;
            }
            else if (nums2[index2] == num1) {
                return num1;
            }
            else
            {
                break;
            }
        }
        index1++;

    }
    return -1;
}