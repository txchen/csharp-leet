public class Solution {
    public Boolean IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        // get x's length in string
        int length = 1;
        while (Math.Pow(10, length) <= x)
        {
            length++;
        }
        while (length > 1)
        {
            // first digit and last digit
            int lastDigit = x % 10;
            int firstDigit = x / (int)Math.Pow(10, length - 1);
            if (lastDigit == firstDigit)
            {
                x = x - (int)Math.Pow(10, length - 1) * firstDigit;
                x /= 10;
                length -= 2;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
