// See https://aka.ms/new-console-template for more information

ValidPath(n: 6, edges: [[0, 1], [0, 2], [3, 5], [5, 4], [4, 3]], source: 0, destination: 5);

bool ValidPath(int n, int[][] edges, int source, int destination)
{
    int[] parent = new int[n];

    for (int i = 0; i < n; i++)
    {
        parent[i] = i;
    }

    foreach (var edge in edges)
    {
        var parentSource = FindParent(parent, edge[0]);
        var parentDest = FindParent(parent, edge[1]);
        if(parentSource != parentDest)
        {
            parent[parentDest] = parentSource;
        }
    }

    return FindParent(parent, source) == FindParent(parent, destination);
}

int FindParent(int[] parent, int node)
{
    if (parent[node] != node)
    {
        node = FindParent(parent, parent[node]);
    }
    return node;
}


