// See https://aka.ms/new-console-template for more information
//Console.WriteLine(FindBottomLeftValue(new TreeNode (1, new TreeNode(2, new TreeNode(4, null,null),null), new TreeNode(3, new TreeNode(5, new TreeNode(7, null,null), null),new TreeNode(6, null, null)))));
Console.WriteLine(FindBottomLeftValue(new TreeNode (2, new TreeNode(1,null,null), new TreeNode(3, null, null))));

int FindBottomLeftValue(TreeNode root)
{
    var dfs = new Queue<TreeNode>();
    var currentNode = root;

    dfs.Enqueue(currentNode);
    while(dfs.Count > 0)
    {
        currentNode = dfs.Dequeue();
        if (currentNode.right != null) dfs.Enqueue(currentNode.right);
        if (currentNode.left != null) dfs.Enqueue(currentNode.left);

    }
    return currentNode.val;
    
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}