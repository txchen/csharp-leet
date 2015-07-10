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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> answer = new List<IList<int>>();
        Stack<TreeNode> stk1 = new Stack<TreeNode>();
        Stack<TreeNode> stk2 = new Stack<TreeNode>();
        stk1.Push(root);
        while (stk1.Count > 0 || stk2.Count > 0)
        {
            List<int> currentLevel = new List<int>();
            if (stk1.Count > 0)
            {
                while (stk1.Count > 0)
                {
                    var temp = stk1.Pop();
                    currentLevel.Add(temp.val);
                    if (temp.left != null)
                    {
                        stk2.Push(temp.left);
                    }
                    if (temp.right != null)
                    {
                        stk2.Push(temp.right);
                    }
                }
            }
            else if (stk2.Count > 0)
            {
                while (stk2.Count > 0)
                {
                    var temp = stk2.Pop();
                    currentLevel.Add(temp.val);
                    if (temp.right != null)
                    {
                        stk1.Push(temp.right);
                    }
                    if (temp.left != null)
                    {
                        stk1.Push(temp.left);
                    }
                }
            }
            answer.Add(currentLevel);
        }
        return answer;
    }
}
