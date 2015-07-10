public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1)
        {
            return 0;
        }
        int[] maxL = new int[prices.Length];
        int[] maxR = new int[prices.Length];
        // first, scan from left to right, get maxL[], max[i] = maxProfit from [0..i]
        int lowest = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < lowest)
            {
                lowest = prices[i];
            }
            maxL[i] = Math.Max(maxL[i - 1], prices[i] - lowest);
        }
        // then, scan from right to left, get maxR[], maxR[i] = maxProfit from [i, end]
        int highest = prices[prices.Length - 1];
        for (int j = prices.Length - 2; j >= 0; j--)
        {
            if (prices[j] > highest)
            {

                highest = prices[j];
            }
            maxR[j] = Math.Max(maxR[j + 1], highest - prices[j]);
        }
        // now scan again, get the answer
        int answer = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            answer = Math.Max(answer, maxL[i] + maxR[i]);
        }
        return answer;
    }
}
