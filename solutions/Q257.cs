public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> result = new List<string>();
        if (root != null)
        {
            BuildPath(root, root.val.ToString(), result);
        }
        return result;
    }

    private void BuildPath(TreeNode node, string currentPath, IList<string> result)
    {
        if (node.left == null && node.right == null)
        {
            result.Add(currentPath);
        }
        if (node.left != null)
        {
            BuildPath(node.left, currentPath + "->" + node.left.val.ToString(), result);
        }
        if (node.right != null)
        {
            BuildPath(node.right, currentPath + "->" + node.right.val.ToString(), result);
        }
    }
}