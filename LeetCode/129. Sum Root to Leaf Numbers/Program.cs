// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine("Hello, World!");


int SumNumbers(TreeNode root)
{
    return Dfs(root, 0);
}

int Dfs(TreeNode node, int num)
{
    if (node == null) return 0;
    if (node.left == null && node.right == null)
    {
        return num * 10 + node.val;
    }
    return Dfs(node.left, num * 10 + node.val) + Dfs(node.right, num * 10 + node.val);
}
