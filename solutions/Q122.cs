public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1)
        {
            return 0;
        }
        int answer = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            answer += Math.Max(0, prices[i] - prices[i - 1]);
        }
        return answer;
    }
}
