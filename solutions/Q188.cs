public class Solution {
    public int MaxProfit(int k, int[] prices) {
        if (k >= prices.Length / 2) {
            int answer = 0;
            for (int i = 1; i < prices.Length; i++) {
                if (prices[i] > prices[i-1]) {
                    answer += prices[i] - prices[i-1];
                }
            }
            return answer;
        }
        // dp
        int[,] dp = new int[k + 1, prices.Length+1];
        for (int i = 1; i <= k; i++ ) {
            int leastLoss = prices[0];
            for (int j = 1; j < prices.Length; j++) {
                dp[i, j] = Math.Max(prices[j] - leastLoss, dp[i, j-1]);
                leastLoss = Math.Min(leastLoss, prices[j] -dp[i-1, j-1]);
            }
        }
        return dp[k, prices.Length -1];
    }
}
