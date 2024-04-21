// See https://aka.ms/new-console-template for more information
using System;
using System.Data;

//Console.WriteLine("Hello, World!");
//Console.WriteLine(IslandPerimeter(grid: [[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]]));
//Console.WriteLine(IslandPerimeter(grid: [[1]]));
Console.WriteLine(IslandPerimeter(grid: [[0, 1]]));
/* [
 * [0,1,0,0],
 * [1,1,1,0],
 * [0,1,0,0],
 * [1,1,0,0]]
 * 
 * 
 */
int IslandPerimeter(int[][] grid)
{
    var perimeter = 0;
    var row = 0;
    var col = 0;
    while (row < grid.Length && col < grid[row].Length)
    {
        if (grid[row][col] == 1)
        {
            perimeter += PerimeterCalculate(grid, row, col);
        }

        row++;
        if (row == grid.Length && col < grid[0].Length)
        {
            row = 0;
            col++;
        }

    }
    return perimeter;
}

int PerimeterCalculate(int[][] grid, int row, int col)
{
    var count = 0;
    if (row - 1 >= 0)
    {
        if (grid[row - 1][col] != 1)
        {
            count++;
        }
    }
    else
    {
        count ++;
    }
    if (row + 1 < grid.Length)
    {
        if (grid[row + 1][col] != 1)
        {
            count++;

        }
    }
    else
    {
        count++;
    }
    if (col - 1 >= 0)
    {
        if (grid[row][col - 1] != 1)
        {
            count++;

        }
    }
    else
    {
        count++;
    }
    if (col + 1 < grid[row].Length)
    {
        if (grid[row][col + 1] != 1)
        {
            count++;

        }
    }
    else
    {
        count++;
    }
    return count;
}