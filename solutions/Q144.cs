public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        if (root == null)
        {
            return new List<int>();
        }
        List<int> answer = new List<int>();
        Stack<TreeNode> stk = new Stack<TreeNode>();
        stk.Push(root);
        while (stk.Count > 0) {
            var n = stk.Pop();
            answer.Add(n.val);
            if (n.right != null) {
                stk.Push(n.right);
            }
            if (n.left != null) {
                stk.Push(n.left);
            }
        }
        return answer;
    }
}
