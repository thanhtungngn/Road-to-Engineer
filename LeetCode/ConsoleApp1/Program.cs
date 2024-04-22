// See https://aka.ms/new-console-template for more information
using Common;


void Merge(int[] nums1, int m, int[] nums2, int n)
{
    for (int i = 0; i < nums1.Length - m; i++)
    {
        nums1[m + i] = nums2[i];
    }
    Array.Sort(nums1);
    Console.WriteLine(nums1.Print());
}


TreeNode InorderSuccessor(TreeNode root, TreeNode p)
{
    var tree = root;
    var result = FindMinSuccessor(root, p, ref tree);
    if (result.val <= p.val) return null;
    return result;
}

TreeNode FindMinSuccessor(TreeNode node, TreeNode p, ref TreeNode currentMin)
{
    if (node == null)
    {
        return currentMin;
    }


    var result = new TreeNode(node.val);
    if (node.val > p.val)
    {
        currentMin = node;

        result = FindMinSuccessor(node.left, p, ref currentMin);
    }
    if (node.val <= p.val)
    {

        result = FindMinSuccessor(node.right, p, ref currentMin);
    }
    return result;
}

//InorderSuccessor(new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(1,null,null));
//InorderSuccessor(new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1), null), new TreeNode(4)), new TreeNode(6)), new TreeNode(1));
InorderSuccessor(new TreeNode(2,null, new TreeNode(3)), new TreeNode(2));