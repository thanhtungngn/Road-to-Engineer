// See https://aka.ms/new-console-template for more information
Console.WriteLine(PivotInteger(8));
Console.WriteLine(PivotInteger(1));
Console.WriteLine(PivotInteger(4));


int PivotInteger(int n)
{
    var sumLeft = 0;
    var sumRight = 0;
    var rightIndex = n;
    var leftIndex = 1;

    while (leftIndex <= rightIndex)
    {
        if (sumLeft <= sumRight)
        {
            if (leftIndex == rightIndex && sumLeft == sumRight)
            {
                return leftIndex;
            }
            sumLeft += leftIndex;
            leftIndex++;
        }
        else
        {
            sumRight += rightIndex;
            rightIndex--;
        }
    }


    return -1;
}