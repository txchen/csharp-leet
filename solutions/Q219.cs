public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!hs.Add(nums[i]))
            {
                return true;
            }
            if (i >= k)
            {
                hs.Remove(nums[i - k]);
            }
        }
        return false;
    }
}
