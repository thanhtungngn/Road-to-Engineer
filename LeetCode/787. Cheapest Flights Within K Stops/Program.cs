// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Console.WriteLine(FindCheapestPrice(n : 4, flights : [[0, 1, 100], [1, 2, 100], [2, 0, 100], [1, 3, 600], [2, 3, 200]], src : 0, dst : 3, k : 1));//return 700
Console.WriteLine(FindCheapestPrice(n : 3, flights : [[0, 1, 100], [1, 2, 100], [0, 2, 500]], src : 0, dst : 2, k : 1)); // return 200
Console.WriteLine(FindCheapestPrice(n : 3, flights : [[0, 1, 100], [1, 2, 100], [0, 2, 500]], src : 0, dst : 2, k : 0)); //return 500

int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
{
    var result = -1;
 
        for (int i = 0; i < flights.Length; i++) {
            if (flights[i][0] == src)
            {

            }
        }
    
    return result;
}