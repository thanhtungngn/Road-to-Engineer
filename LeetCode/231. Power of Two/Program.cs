// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsPowerOfTwo(1));
Console.WriteLine(IsPowerOfTwo(16));
Console.WriteLine(IsPowerOfTwo(3));

bool IsPowerOfTwo(int n)
{
    while (n > 1 && n % 2 == 0)
    {
        n /= 2;
    }
    return n == 1;
}