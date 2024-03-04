// See https://aka.ms/new-console-template for more information
using System.Linq;

//Console.WriteLine("Hello, World!");
//Console.WriteLine(Solution(x: "ABCD", y : "AC"));
//Console.WriteLine(Solution(x: "ABCD", y : "CA"));
//Console.WriteLine(Solution(x: "ABCAD", y : "BA"));

//Console.WriteLine(Validate(["--help", "--abd", "--abds"]));
Console.WriteLine(solution(["fred:joe", "joe:mary", "mary:fred", "mary:bill"], "fred", "bill"));



bool Solution(string x, string y)
{
    if (string.IsNullOrEmpty(y))
    {
        return true;
    }

    if (string.IsNullOrEmpty(x))
    {
        return false;
    }

    Stack<char> stack = new Stack<char>();
    for (int i = 0; i < y.Length; i++)
    {
        stack.Push(y[i]);
    }
    for (int i = x.Length - 1; i >= 0 && stack.Count > 0; i--)
    {
        if (stack.Peek() == x[i])
        {
            stack.Pop();
        }
    }
    return stack.Count == 0;
}

List<List<string>> SplitArgs(string[] args)
{
    var listArg = new List<string> { "--name", "--help", "--count" };

    var result = new List<List<string>>();
    var current = new List<string>();

    for (int i = 0; i < args.Length; i++)
    {
        if (listArg.Contains(args[i].ToLower()))
        {
            result.Add(current);
            current = new List<string>();

        }
        current.Add(args[i]);
    }
    result.Add(current);

    result.RemoveAt(0);
    return result;
}

int Validate(string[] args)
{
    if (args.Length == 0) { return -1; }
    var arraySplit = SplitArgs(args);
    if (arraySplit.Count == 0) return -1;

    var currentStatus = true;
    var isHelp = false;
    for (int i = 0; i < arraySplit.Count && currentStatus; i++)
    {
        if (arraySplit[i][0].ToLower() == "--help")
        {
            if (arraySplit[i].Count > 2)
            {
                return -1;
            }
            isHelp = true;
        }
        else if (arraySplit[i].Count == 2)
        {
            switch (arraySplit[i][0].ToLower())
            {
                case "--name":
                    currentStatus = arraySplit[i][1].Length >= 3 && arraySplit[i][1].Length <= 10;
                    break;
                case "--count":
                    currentStatus = int.TryParse(arraySplit[i][1], out var number);
                    currentStatus = number >= 10 && number <= 100;
                    break;
                case "--help":
                    isHelp = true;
                    break;
                default: currentStatus = false; break;
            }
        }
        else
        {
            return -1;
        }
    }
    if (!currentStatus) return -1;

    return isHelp ? 1 : 0;
}

int solution(string[] Connections, string Name1, string Name2)
{
    Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();

    for (int i = 0; i < Connections.Length; i++)
    {
        var people = Connections[i].Split(':');
        if (!graph.ContainsKey(people[0]))
        {
            graph.Add(people[0], new List<string>());
        }
       
            graph[people[0]].Add(people[1]);
        

        if (!graph.ContainsKey(people[1]))
        {
            graph.Add(people[1], new List<string>());
        }
      
            graph[people[1]].Add(people[0]);
        

    }

    return BFS(graph,Name1,Name2);
}

int BFS(Dictionary<string, List<string>> graph, string start, string end)
{
    Queue<string> queue = new Queue<string>();
    queue.Enqueue(start);
    List<string> connection = new List<string>();
    var degree = 0;
    
    while(queue.Count > 0)
    {
        var queueCount = queue.Count;
        for (int i = 0; i< queueCount; i++)
        {
            var person = queue.Dequeue();
            if(person == end) {
                return degree;
            }
            if(!connection.Contains(person)) {
                connection.Add(person);
            }
            if(!graph.ContainsKey(person))
            {
                return -1;
            }
            foreach (var p in graph[person])
            {
                if(!connection.Contains(p))
                {
                    queue.Enqueue(p);
                }
            }
        }
        degree++;
    }
    return -1;
}