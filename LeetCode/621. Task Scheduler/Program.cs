// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;

Console.WriteLine("Hello, World!");
Console.WriteLine(LeastInterval(tasks: ['A', 'A', 'A', 'B', 'B', 'B'], n: 2));
Console.WriteLine(LeastInterval(tasks: ['A', 'C', 'A', 'B', 'D', 'B'], n: 1));
Console.WriteLine(LeastInterval(tasks: ['A', 'A', 'A', 'B', 'B', 'B'], n: 3));

int LeastInterval(char[] tasks, int n)
{
    int[] frequencies = new int[26];
    foreach (char task in tasks)
    {
        frequencies[task - 'A']++;
    }

    Array.Sort(frequencies);

    int maxFrequency = frequencies[25] - 1;
    int idleSlots = maxFrequency * n;

    for (int i = 24; i >= 0 && frequencies[i] > 0; i--)
    {
        idleSlots -= Math.Min(frequencies[i], maxFrequency);
    }

    return Math.Max(idleSlots, 0) + tasks.Length;


}