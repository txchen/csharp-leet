public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if (nums.Length == 0) {
            return new List<string>();
        }
        List<string> result = new List<string>();
        int currentStart = nums[0];
        int currentEnd = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == currentEnd + 1) {
                currentEnd = nums[i];
            } else {
                result.Add(GenSeg(currentStart, currentEnd));
                currentStart = currentEnd = nums[i];
            }
        }
        result.Add(GenSeg(currentStart, currentEnd));
        return result;
    }

    private string GenSeg(int start, int end) {
        if (start == end) {
            return start.ToString();
        } else {
            return start.ToString() + "->" + end.ToString();
        }
    }
}
