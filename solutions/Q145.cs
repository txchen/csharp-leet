public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        if (root == null) {
            return new List<int>();
        }
        Stack<TreeNode> stk = new Stack<TreeNode>();
        Stack<int> answer = new Stack<int>();
        stk.Push(root);
        while (stk.Count > 0) {
            var n = stk.Pop();
            answer.Push(n.val);
            if (n.left != null) {
                stk.Push(n.left);
            }
            if (n.right != null) {
                stk.Push(n.right);
            }
        }
        List<int> a = new List<int>();
        while (answer.Count > 0) {
            a.Add(answer.Pop());
        }
        return a;
    }
}
