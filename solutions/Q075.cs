public class Solution {
    public void SortColors(int[] nums) {
        int zeroIndex = 0;
        int twoIndex = nums.Length - 1;
        int scan = 0;
        while (scan <= twoIndex)
        {
            if (nums[scan] == 0)
            {
                if (scan > zeroIndex)
                {
                    nums[scan] = nums[zeroIndex];
                    nums[zeroIndex++] = 0;
                }
                else
                {
                    zeroIndex++;
                    scan++;
                }
            }
            else if (nums[scan] == 2)
            {
                if (scan < twoIndex)
                {
                    nums[scan] = nums[twoIndex];
                    nums[twoIndex--] = 2;
                }
                else
                {
                    break;
                }
            }
            else
            {
                scan++;
            }
        }
    }
}
