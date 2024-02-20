// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine(FurthestBuilding([1, 5, 1, 2, 3, 4, 10000],4,1));
//Console.WriteLine(FurthestBuilding([4, 2, 7, 6, 9, 14, 12], 5, ladders: 1));
//Console.WriteLine(FurthestBuilding([14, 3, 19, 3], bricks: 17, ladders: 0));


int FurthestBuilding(int[] heights, int bricks, int ladders)
{
    //var distances = new int[heights.Length];

    var maxDiff = new PriorityQueue<int, int>();
    int sum = 0;
    for (int i = 1; i < heights.Length; i++)
    {
        var next = heights[i] - heights[i - 1];
        if (next > 0)
        {
            // Push the value with priority as index
            maxDiff.Enqueue(next, -next);
            sum += next; // use bricks with distance between buildings
        }

        // If sum is greater than bricks, then we need to use ladder
        if (sum > bricks)
        {
            // If we have ladders, then we can use it
            if (ladders > 0)
            {
                // Get the max diff and remove it from sum
                sum -= maxDiff.Dequeue();
                ladders--;
            }
            else
            {
                return i - 1;
            }
        }
    }
    return heights.Length - 1;

}



  
