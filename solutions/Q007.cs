public class Solution {
    public int Reverse(int x) {
        bool isNeg = x < 0;
        x = isNeg ? 0 - x : x;
        long res = 0;
        while (x > 0)
        {
            int lowest = x % 10;
            res = res * 10 + lowest;
            x = x / 10;
        }
        if (res > int.MaxValue) {
            return 0;
        }
        return isNeg ? (int)(0 - res) : (int)res;
    }
}
