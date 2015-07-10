public class Solution {
    public int[] PlusOne(int[] digits) {
        int[] result = new int[digits.Length];
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int tmp = carry + digits[i];
            carry = tmp / 10;
            result[i] = tmp % 10;
        }
        if (carry == 0)
        {
            return result;
        }
        return (new int[1] { 1 }).Concat(result).ToArray();
    }
}
