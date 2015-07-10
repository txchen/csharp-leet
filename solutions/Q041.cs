public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            int currentValue = nums[i];
            int shouldBeAt = currentValue - 1;
            while (i != shouldBeAt && shouldBeAt >= 0 && shouldBeAt <= nums.Length -1)
            {
                // swap i and shouldBeAt, put the value in the 'correct' position
                if (nums[i] == nums[shouldBeAt])
                {
                    break;
                }
                nums[i] = nums[shouldBeAt];
                nums[shouldBeAt] = currentValue;
                currentValue = nums[i];
                shouldBeAt = currentValue - 1;
            }
        }
        // now scan from start to end, find the first wrong number
        // the data should be [1, 2, 3, 4, 5....], the first wrong number is the answer
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != j + 1)
            {
                return j + 1;
            }
        }
        return nums.Length + 1;
    }
}
