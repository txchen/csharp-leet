public class Solution {
    public int CountDigitOne(int n) {
        if (n <= 0) {
            return 0;
        } else if (n < 10) {
            return 1;
        }
        int length = n.ToString().Length;
        int highestBase = (int)Math.Pow(10, length - 1);
        int highest = n / highestBase;
        int remaining = n % highestBase;
        int onesInHighest = 0;
        if (highest == 1) {
            onesInHighest = remaining + 1;
        } else {
            onesInHighest = highestBase;
        }
        return onesInHighest + CountDigitOne(remaining) + CountDigitOne(highestBase - 1) * highest;
    }
}
