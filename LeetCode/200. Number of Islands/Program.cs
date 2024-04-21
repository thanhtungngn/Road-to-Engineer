// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine(NumIslands(grid : [ ['1', '1', '1', '1', '0'],['1', '1', '0', '1', '0'],['1', '1', '0', '0', '0'],['0', '0', '0', '0', '0']]));
Console.WriteLine(NumIslands(grid : [['1', '1', '0', '0', '0'],    ['1', '1', '0', '0', '0'],    ['0', '0', '1', '0', '0'],    ['0', '0', '0', '1', '1']]));
int NumIslands(char[][] grid)
{
    var islandCount = 0;
    var islandArr = new HashSet<(int, int)>();

    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[0].Length; j++)
        {
            if (grid[i][j] == '1')
            {
                if (!islandArr.Contains((i, j)))
                {
                    islandCount++;
                    islandArr.Add((i, j));
                    isSameIsland(grid, i, j, ref islandArr);
                }
            }
        }

    }
    return islandCount;
}

void isSameIsland(char[][] grid, int row, int col, ref HashSet<(int, int)> islands)
{
    
    if (row - 1 >= 0)
    {
        if (grid[row - 1][col] == '1' && !islands.Contains((row - 1, col)))
        {
            islands.Add((row - 1, col));
            isSameIsland(grid, row - 1, col, ref islands);
        }
    }

    if (row + 1 < grid.Length)
    {
        if (grid[row + 1][col] == '1' && !islands.Contains((row + 1, col)))
        {
            islands.Add((row + 1, col));
            isSameIsland(grid, row +1, col, ref islands);

        }
    }

    if (col - 1 >= 0)
    {
        if (grid[row][col - 1] == '1' && !islands.Contains((row, col-1)))
        {
            islands.Add((row, col - 1));

            isSameIsland(grid, row, col - 1, ref islands);

        }
    }

    if (col + 1 < grid[row].Length)
    {
        if (grid[row][col + 1] == '1' && !islands.Contains((row, col+1)))
        {
            islands.Add((row, col + 1));

            isSameIsland(grid, row, col + 1, ref islands);

        }
    }
}