// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine("Hello, World!");
Console.WriteLine(DeckRevealedIncreasing([17, 13, 11, 2, 3, 5, 7,8]).Print());

int[] DeckRevealedIncreasing(int[] deck)
{
    int N = deck.Length;
    int[] result = new int[N];
    var skip = false;
    int indexInDeck = 0;
    int indexInResult = 0;

    Array.Sort(deck);

    while (indexInDeck < N)
    {
        // There is an available gap in result
        if (result[indexInResult] == 0)
        {

            // Add a card to result
            if (!skip)
            {
                result[indexInResult] = deck[indexInDeck];
                indexInDeck++;
            }

            // Toggle skip to alternate between adding and skipping cards
            skip = !skip;
        }
        // Progress to next index of result array
        indexInResult = (indexInResult + 1) % N;
    }
    return result;
}
