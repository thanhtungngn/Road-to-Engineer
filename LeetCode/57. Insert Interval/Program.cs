// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine("Hello, World!");

Console.WriteLine(Insert(intervals: [[1, 3], [6, 9]], newInterval: [2, 5]).Print());
Console.WriteLine(Insert(intervals: [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], newInterval: [4, 8]).Print());
Console.WriteLine(Insert(intervals: [[1, 5]], newInterval: [0, 3]).Print());

int[][] Insert(int[][] intervals, int[] newInterval)
{

    var result = new List<int[]>();

    if (intervals.Length == 0)
    {
        result.Add(newInterval);
        return result.ToArray();
    }

    var insect = new int[2];

    var overlap = false;
    var comparedInterval = false;

    for (int i = 0; i < intervals.Length; i++)
    {
        if (!overlap)
        {
            if (intervals[i][0] <= newInterval[0])
            {
                if (intervals[i][1] < newInterval[0])
                {
                    result.Add(intervals[i]);
                    if (i == intervals.Length - 1)
                    {
                        result.Add(newInterval);
                    }
                }
                else
                {
                    if (intervals[i][1] > newInterval[1])
                    {
                        result.Add([intervals[i][0], intervals[i][1]]);
                    }
                    else
                    {
                        insect[0] = intervals[i][0];
                        overlap = true;
                    }
                    comparedInterval = true;

                }

            }
            else
            {
                if (intervals[i][0] <= newInterval[1])
                {
                    if (intervals[i][1] <= newInterval[1])
                    {
                        insect[0] = newInterval[0];
                        overlap = true;
                    }
                    else
                    {
                        result.Add([newInterval[0], intervals[i][1]]);
                    }
                    comparedInterval = true;
                }
                else
                {
                    if (!comparedInterval)
                    {
                        result.Add(newInterval);
                    }
                    result.Add(intervals[i]);
                    comparedInterval = true;
                }
            }

        }
        else
        {
            if (intervals[i][0] <= newInterval[1])
            {
                if (intervals[i][1] <= newInterval[1])
                {
                    continue;
                }
                else
                {
                    insect[1] = intervals[i][1];
                    result.Add(insect);
                    overlap = false;
                }
            }
            else
            {
                insect[1] = newInterval[1];
                result.Add(insect);
                overlap = false;
                result.Add(intervals[i]);
            }
            comparedInterval = true;

        }
    }


      
    if (overlap)
    {
        insect[1] = newInterval[1];
        result.Add(insect);
    }
    return result.ToArray();
}