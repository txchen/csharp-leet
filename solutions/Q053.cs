public class Solution {
    public int MaxSubArray(int[] nums) {
        int answer = nums[0];
        int currentSum = nums[0] > 0 ? nums[0] : 0;
        for (int i = 1; i < nums.Length; i++)
        {
            currentSum += nums[i];
            answer = Math.Max(answer, currentSum);
            if (currentSum <= 0)
            {
                currentSum = 0;
            }
        }
        return answer;
    }
}
