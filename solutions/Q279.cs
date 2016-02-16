public class Solution {
    public int NumSquares(int n)
    {
        int[] dp = new int[n+1];
        for (int i=1; i<=n; i++)
        {
            dp[i] = i;
            for (int j = 1; j * j <= i; j++)
            {
                dp[i] = Math.Min(dp[i - j * j] + 1, dp[i]);
            }
        }
        return dp[n];
    }
}