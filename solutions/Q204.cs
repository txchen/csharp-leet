public class Solution {
    public int CountPrimes(int n) {
        if (n <= 2) {
            return 0;
        }
        BitArray ba = new BitArray(n);
        int answer = n - 2; // 1 and n should not be counted
        for (int i = 2; i < n ; i++) {
            for (int j = i + i; j < n ; j+=i) {
                if (!ba[j]) {
                    ba[j] = true;
                    answer--;
                }
            }
        }
        return answer;
    }
}
