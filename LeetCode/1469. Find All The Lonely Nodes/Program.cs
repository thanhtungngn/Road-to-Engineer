// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine(GetLonelyNodes(new TreeNode(11, new TreeNode(99, new TreeNode(77), null)
    , new TreeNode(88, null,null))).ToArray().Print());

IList<int> GetLonelyNodes(TreeNode root)
{
    var result = new List<int>();
    IsLonely(root, ref result);
    return result;
}

void IsLonely(TreeNode node, ref List<int> result)
{

    if(node != null)
    {
        if(node.left == null && node.right!=null)
        {
            result.Add(node.right.val);
            IsLonely(node.left, ref result);

        }
        else if (node.right == null && node.left != null)
        {
            result.Add(node.left.val);
            IsLonely(node.right, ref result);

        }
        else if (node.right == null && node.left == null) 
        {
        }
        else
        {
            IsLonely(node.right, ref result);
            IsLonely(node.left, ref result);
        }

    }
}