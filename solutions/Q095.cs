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
    public IList<TreeNode> GenerateTrees(int n) {
        return GenerateTrees(1, n);
    }

    private IList<TreeNode> GenerateTrees(int from, int to)
    {
        if (from > to)
        {
            return new TreeNode[1];
        }
        List<TreeNode> answer = new List<TreeNode>();
        for (int i = from; i <= to; i++)
        {
            var lefts = GenerateTrees(from, i - 1);
            var rights = GenerateTrees(i + 1, to);
            foreach (var left in lefts)
            {
                foreach (var right in rights)
                {
                    TreeNode root = new TreeNode(i);
                    root.left = left;
                    root.right = right;
                    answer.Add(root);
                }
            }

        }
        return answer;
    }

}
