// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine(FindJudge(n: 2, trust: [[1, 2]]));
Console.WriteLine(FindJudge(n: 3, trust: [[1, 3], [2, 3]]));
Console.WriteLine(FindJudge(n: 3, trust: [[1, 3], [2, 3], [3, 1]]));

int FindJudge(int n, int[][] trust)
{
    if(n == 1 && trust.Length ==0)
    {
        return n;
    }
    var trustedPeople = new Dictionary<int, int>();
    var peopleTrust = new Dictionary<int, int>();

    for (int i = 0; i < trust.Length; i++)
    {
        if (peopleTrust.ContainsKey(trust[i][0]))
        {
            peopleTrust[trust[i][0]]++;
        }
        else
        {
            peopleTrust.Add(trust[i][0], 1);
        }

        if (trustedPeople.ContainsKey(trust[i][1]))
        {
            trustedPeople[trust[i][1]]++;
        }
        else
        {
            trustedPeople.Add(trust[i][1], 1);
        }
       
    }

    var judgeSus = trustedPeople.Where(x => x.Value == n - 1 && !peopleTrust.ContainsKey(x.Key));
    if(judgeSus.Count() == 1)
    {
        return judgeSus.FirstOrDefault().Key;
    }

    return -1;
}