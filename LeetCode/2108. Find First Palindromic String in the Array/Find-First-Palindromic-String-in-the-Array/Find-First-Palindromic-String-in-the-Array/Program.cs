// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]));
Console.WriteLine(FirstPalindrome(["notapalindrome", "racecar"]));
Console.WriteLine(FirstPalindrome(["def", "ghi"]));



string FirstPalindrome(string[] words)
{
    string result = string.Empty;
    for (int i = 0; i< words.Length; i++)
    {
        if (isPalindronmic(words[i]))
        {
            return words[i];
        }
    }
    return result;
}

bool isPalindronmic(string word)
{
    int index = 0;
    int lastIndex = word.Length-1;
    while(index <= lastIndex)
    {
        if (word[index] != word[lastIndex])
        {
            return false;
        }
        index++;
        lastIndex--;
    }
    return true;

}
