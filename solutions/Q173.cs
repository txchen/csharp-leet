/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {

    private Stack<TreeNode> stk = new Stack<TreeNode>();

    public BSTIterator(TreeNode root) {
        while (root != null) {
            stk.Push(root);
            root = root.left;
        }
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return stk.Count > 0;
    }

    /** @return the next smallest number */
    public int Next() {
        var n = stk.Pop();
        int r = n.val;
        n = n.right;
        while (n != null) {
            stk.Push(n);
            n = n.left;
        }
        return r;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */
