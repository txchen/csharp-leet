public class Solution {
    public int[] SingleNumber(int[] nums)
    {
        int xor = 0;
        nums.ToList().ForEach(n => xor = xor ^ n);
        // xor = a ^ b, find any '1' in the xor
        int mask = 1;
        while ((mask & xor) == 0)
        {
            mask = mask << 1;
        }
        // a or b, one of them, will have '1' at the mask position
        int a = 0;
        nums.ToList().ForEach(n => {
            if ((mask & n) > 0)
            {
                a = a ^ n;
            }
        });
        return new int[2] { a, xor ^ a };
    }
}