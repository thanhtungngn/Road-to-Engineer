// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine(CanPlaceFlowers([1, 0, 0, 0, 1], 1));
Console.WriteLine(CanPlaceFlowers([1, 0, 0, 0, 1], 2));

bool CanPlaceFlowers(int[] flowerbed, int n)
{

    if (flowerbed[0] == 0 && flowerbed.Length == 1)
    {
        flowerbed[0] = 1;
        n = n - 1;
    }
    else if (!flowerbed.Contains(1) && flowerbed.Length == 2)
    {
        flowerbed[0] = 1;
        n = n - 1;
    }
    else if( flowerbed.Length > 2)
    {
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if(i == 0)
            {
                if (flowerbed[i] == 0)
                {
                    if (flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1;
                        n = n - 1;
                    }
                }
            }
            else if(i == flowerbed.Length-1)
            {
                if (flowerbed[i] == 0)
                {
                    if (flowerbed[i -1] == 0)
                    {
                        flowerbed[i] = 1;
                        n = n - 1;
                    }
                }
            }
            else
            {
                if (flowerbed[i] == 0 && flowerbed[i-1] !=0 && flowerbed[i+1] !=0) {
                    flowerbed[i] = 1;
                    n = n - 1;
                }
            }

        }
    }

    return n >= 0;


}
