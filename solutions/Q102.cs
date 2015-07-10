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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> answer = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            List<int> currentLevel = new List<int>();
            Queue<TreeNode> nq = new Queue<TreeNode>();
            while(q.Count > 0)
            {
                var node = q.Dequeue();
                currentLevel.Add(node.val);
                if (node.left != null)
                {
                    nq.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nq.Enqueue(node.right);
                }
            }
            answer.Add(currentLevel.ToList());
            q = nq;
        }
        return answer;
    }
}
