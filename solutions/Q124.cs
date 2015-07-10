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
    public int MaxPathSum(TreeNode root) {
        return MaxPathSumInt(root).Item2;
    }

    // Item1, answer that including root, can be combine with upstream node, so it can only connect to 1 child
    // Item2, answer
    public Tuple<int, int> MaxPathSumInt(TreeNode root)
    {
        if (root == null)
        {
            return Tuple.Create(0, 0);
        }
        if (root.left == null && root.right == null)
        {
            return Tuple.Create(root.val, root.val);
        }
        if (root.left == null)
        {
            var rAnswer = MaxPathSumInt(root.right);
            int item1 = Math.Max(0, rAnswer.Item1) + root.val;
            int item2 = (new[] { item1, rAnswer.Item2 }).Max();
            return Tuple.Create(item1, item2);
        }
        if (root.right == null)
        {
            var lAnswer = MaxPathSumInt(root.left);
            int item1 = Math.Max(0, lAnswer.Item1) + root.val;
            int item2 = (new[] { item1, lAnswer.Item2 }).Max();
            return Tuple.Create(item1, item2);
        }
        // left and right both exist
        var ll = MaxPathSumInt(root.left);
        var rr = MaxPathSumInt(root.right);
        int a1 = Math.Max(0, Math.Max(ll.Item1, rr.Item1)) + root.val;
        int a2 = (new[] { a1, ll.Item2, rr.Item2, (root.val + ll.Item1 + rr.Item1) }).Max();
        return Tuple.Create(a1, a2);
    }
}
