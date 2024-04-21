// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

Console.WriteLine("Hello, World!");
//Console.WriteLine(EqualPairs([[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]]));
Console.WriteLine(EqualPairs([[13, 13], [13, 13]]));

int EqualPairs(int[][] grid)
{
    Dictionary<string, int> col = new Dictionary<string, int>();
    Dictionary<string, int> row = new Dictionary<string, int>();

    for (int i = 0; i < grid.Length; i++)
    {
        var stringKeyRow = new StringBuilder(grid.Length);
        foreach (int x in grid[i])
        {
            stringKeyRow.Append($" {x}");
        }
        var keyRow = stringKeyRow.ToString();
        if (!row.TryAdd(keyRow, 1))
        {
            row[keyRow]++;
        }

        var stringKeyCol = new StringBuilder(grid.Length);

        for (int j = 0; grid[i].Length > j; j++)
        {
            stringKeyCol.Append($" {grid[j][i]}");
        }
        var keyCol = stringKeyCol.ToString();

        if (!col.TryAdd(keyCol, 1))
        {
            col[keyCol]++;
        }
    }

    var result = 0;

    foreach (var colArr in col.Keys)
    {
        if (row.TryGetValue(colArr, out var value))
        {
            result += row[colArr] * col[colArr];
        }
    }
    return result;




}