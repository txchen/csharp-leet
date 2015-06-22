public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        int shift = 0;
        while (m != n) {
            m = m >> 1;
            n = n >> 1;
            shift++;
        }
        return n << shift;
    }
}
