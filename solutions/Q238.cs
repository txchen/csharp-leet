public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // [a, b, c, d]
        // pass 1, make [1, a, ab, abc]
        int[] answer = new int[nums.Length];
        int left = 1;
        for (int i = 0; i < nums.Length; i++) {
            answer[i] = left;
            left = left * nums[i];
        }
        // pass 2, right to left, [bcd, acd, abd, abc]
        int right = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            answer[i] *= right;
            right = right * nums[i];
        }
        return answer;
    }
}
