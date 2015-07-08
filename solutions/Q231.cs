public class Solution {
    public bool IsPowerOfTwo(int n) {
        int numOfOne = 0;
        while (n > 0) {
            if ((n & 1) > 0) {
                numOfOne++;
            }
            n = n >> 1;
        }
        return numOfOne == 1;
    }
}
