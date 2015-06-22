public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;
        if (k == 0 || nums.Length < 2) {
            return;
        }
        // rotate 0..n-k-1
        int left = 0;
        int right = n - k - 1;
        do {
            int t = nums[left];
            nums[left] = nums[right];
            nums[right] = t;
        } while (++left < --right);
        // rotate n-k..n-1
        left = n-k;
        right = n-1;
        do {
            int t = nums[left];
            nums[left] = nums[right];
            nums[right] = t;
        } while (++left < --right);
        // rotate all
        left = 0;
        right = n-1;
        do {
            int t = nums[left];
            nums[left] = nums[right];
            nums[right] = t;
        } while (++left < --right);
    }
}
