public class Solution {
    public int MissingNumber(int[] nums)
    {
        int xor = 0;
        for (int i = 1; i <= nums.Length; i++)
        {
            xor = xor ^ i;
        }
        nums.ToList().ForEach(n => xor = xor ^ n);
        return xor;
    }
}