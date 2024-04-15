// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine(SumOfLeftLeaves(new TreeNode(3, new TreeNode(9,null,null), new TreeNode(20, new TreeNode(15,null,null),new TreeNode(7,null,null)))));
Console.WriteLine(SumOfLeftLeaves(new TreeNode(1, new TreeNode(2,new TreeNode(4,null,null), new TreeNode(5,null,null)), new TreeNode(3, null,null))));

int SumOfLeftLeaves(TreeNode root)
{
    var result = 0;
    var currentNode = root;
    if (currentNode != null && currentNode.left != null)
    {
        if(!HasChildren(currentNode.left))
        {
            result += currentNode.left.val;

        }
    }

    if(currentNode.left != null)
    {
        result += SumOfLeftLeaves(currentNode.left);
    }
    if(currentNode.right != null)
    {
        result += SumOfLeftLeaves(currentNode.right);

    }


    return result;
}

bool HasChildren(TreeNode node)
{
    return node.left != null || node.right != null;
}