public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1)
        {
            return 0;
        }
        int lowest = prices[0];
        int answer = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < lowest)
            {
                lowest = prices[i];
            }
            answer = Math.Max(answer, prices[i] - lowest);

        }
        return answer;
    }
}
