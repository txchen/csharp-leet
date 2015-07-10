/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> answer = new List<IList<int>>();
        List<int> currentPath = new List<int>();
        PathSum(root, sum, answer, currentPath);
        return answer;
    }

    private void PathSum(TreeNode root, int sum, List<IList<int>> answer, List<int> currentPath)
    {
        if (root.left == null && root.right == null && sum == root.val)
        {
            currentPath.Add(root.val);
            answer.Add(currentPath.ToList());
            currentPath.RemoveAt(currentPath.Count - 1);
            return;
        }
        if (root.left != null)
        {
            currentPath.Add(root.val);
            PathSum(root.left, sum - root.val, answer, currentPath);
            currentPath.RemoveAt(currentPath.Count - 1);
        }
        if (root.right != null)
        {
            currentPath.Add(root.val);
            PathSum(root.right, sum - root.val, answer, currentPath);
            currentPath.RemoveAt(currentPath.Count - 1);
        }
    }

}
