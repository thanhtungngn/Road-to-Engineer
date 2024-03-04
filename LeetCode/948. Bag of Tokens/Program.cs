// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Console.WriteLine(BagOfTokensScore([100, 200, 300, 400], 200));
//Console.WriteLine(BagOfTokensScore([100], 50));
Console.WriteLine(BagOfTokensScore([200, 100], 150));

int BagOfTokensScore(int[] tokens, int power)
{
    var score = 0;

    Array.Sort(tokens);

    var indexFirst = 0;
    var indexLast = tokens.Length - 1;
    while (indexFirst <= indexLast)
    {
        if (power >= tokens[indexFirst])
        {

            score++;
            power -= tokens[indexFirst];

            indexFirst++;
        }
        else if (score > 0 && indexFirst < indexLast-1)
        {
            score--;
            power += tokens[indexLast];
            indexLast--;
        }
        else
        {
            return score;
        }
    }
    return score;
}
