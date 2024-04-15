// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int TimeRequiredToBuy(int[] tickets, int k)
{
    var result = 0;
    var timesToBuy = tickets[k];
    for (int i = 0; i < tickets.Length; i++)
    {
        if (tickets[i] < timesToBuy)
        {
            result += tickets[i];
        }
        else
        {
            if(i > k)
            {
                result += timesToBuy - 1;
            }
            else
            {
                result += timesToBuy;

            }
        }

    }

    return result;
}