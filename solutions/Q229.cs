public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        // at most, there are 2 nums in result
        int candidate1 = 0, candidate2 = 0, count1 = 0, count2 = 0;
        foreach (int n in nums) {
            if (count1 == 0 || n == candidate1) {
                count1++;
                candidate1 = n;
            } else if (count2 == 0 || n == candidate2) {
                count2++;
                candidate2 = n;
            } else {
                count1--;
                count2--;
            }
        }
        count1 = count2 = 0;
        foreach (int n in nums) {
            if (n == candidate1) {
                count1++;
            } else if (n == candidate2) {
                count2++;
            }
        }
        var result = new List<int>();
        if (count1 > nums.Length / 3) {
            result.Add(candidate1);
        }
        if (count2 > nums.Length / 3) {
            result.Add(candidate2);
        }
        return result;
    }
}
