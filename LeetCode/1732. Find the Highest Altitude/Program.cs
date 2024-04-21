// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int LargestAltitude(int[] gain)
{
    var attitude = new int[gain.Length+1];
    var max = 0;
    
    for (int i = 0; i < gain.Length; i++)
    {
        attitude[i+1] = attitude[i]+gain[i];
        max = Math.Max(attitude[i], max);
    }
    return max;
}