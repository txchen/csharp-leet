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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        List<TreeNode> currentLayer = new List<TreeNode>() { root };
        Stack<IList<int>> answer = new Stack<IList<int>>();
        while (true)
        {
            answer.Push(currentLayer.Select(n => n.val).ToList());
            var nextLayer = new List<TreeNode>();
            currentLayer.ForEach(n =>
            {
                if (n.left != null)
                {
                    nextLayer.Add(n.left);
                }
                if (n.right != null)
                {
                    nextLayer.Add(n.right);
                }
            });
            if (nextLayer.Count == 0)
            {
                break;
            }
            currentLayer = nextLayer;
        }
        return answer.ToList();
    }
}
