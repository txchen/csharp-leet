public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (k < 1 || t < 0) {
            return false;
        }
        int bucketSize = t + 1;
        Dictionary<long, long> dic = new Dictionary<long, long>();
        for (int i = 0; i < nums.Length; i++) {
            long bucketIndex = nums[i] / bucketSize;
            if (nums[i] < 0) {
                bucketIndex -= 1; // Notice: -4 / 5 = 0, so for negative, need to adjust
            }
            if (dic.ContainsKey(bucketIndex) ||
                (dic.ContainsKey(bucketIndex - 1) && Math.Abs(dic[bucketIndex - 1] - nums[i]) <= t) ||
                (dic.ContainsKey(bucketIndex + 1) && Math.Abs(dic[bucketIndex + 1] - nums[i]) <= t)) {
                return true;
            }
            dic[bucketIndex] = nums[i];
            if (dic.Count > k) {
                dic.Remove(nums[i - k] / bucketSize);
            }
        }
        return false;
    }
}
