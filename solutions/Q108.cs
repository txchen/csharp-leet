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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0)
        {
            return null;
        }
        TreeNode root = new TreeNode(nums[nums.Length / 2]);
        root.left = SortedArrayToBST(nums.Take(nums.Length / 2).ToArray());
        root.right = SortedArrayToBST(nums.Skip(nums.Length / 2 + 1).ToArray());
        return root;
    }
}
