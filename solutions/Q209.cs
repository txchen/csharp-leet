public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        int left = -1;
        int right = 0;
        int sum = 0;
        int answer = nums.Length + 1;
        while (right < nums.Length) {
            sum += nums[right];
            if (sum >= s) {
                while (left < right) {
                    if ((sum - nums[left+1]) >= s) {
                        sum -= nums[left+1];
                        left++;
                    } else {
                        break;
                    }
                }
                answer = Math.Min(answer, right - left);
            }
            right++;
        }
        return answer > nums.Length ? 0 : answer;
    }
}
