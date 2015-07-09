public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        return FindKthLargestInternal(nums, k - 1, 0, nums.Length - 1);
    }

    private int FindKthLargestInternal(int[] nums, int k, int low, int high) {
        int p = Partition(nums, low, high);
        if (p == k) {
            return nums[p];
        } else if (p > k) {
            return FindKthLargestInternal(nums, k, low, p - 1);
        } else {
            return FindKthLargestInternal(nums, k, p + 1, high);
        }
    }

    private int Partition(int[] nums, int low, int high) {
        int pivotVal = nums[(low + high) / 2];
        // put the pivotVal in leftMost
        nums[(low + high) / 2] = nums[low];
        nums[low] = pivotVal;
        int pivotIndex = low;
        for (int i = low + 1; i <= high; i++) {
            if (nums[i] > pivotVal) {
                int temp = nums[i];
                nums[i] = nums[++pivotIndex];
                nums[pivotIndex] = temp;
            }
        }
        // now put the pivotVal back to its correct position
        nums[low] = nums[pivotIndex];
        nums[pivotIndex] = pivotVal;
        return pivotIndex;
    }
}
