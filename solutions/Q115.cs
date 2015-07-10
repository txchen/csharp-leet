public class Solution {
    public int NumDistinct(string s, string t) {
        // dp[x, y] means NumDistinct(src.SubString(0, x), tgt.SubString(0, y))
        // dp[x, 0] = 1
        // dp[x, y] = src[x-1] == tgt[y-1] ? dp[x-1, y-1] + dp[x-1, y] : dp[x-1, y]
        // answer = dp[src.Length, tgt.Length]
        int[,] dp = new int[s.Length + 1, t.Length + 1];
        for (int i = 0; i < s.Length + 1; i++)
        {
            dp[i, 0] = 1;
        }
        for (int x = 1; x <= s.Length; x++)
        {
            for (int y = 1; y <= t.Length; y++)
            {
                dp[x, y] = s[x - 1] == t[y - 1] ?
                    dp[x - 1, y - 1] + dp[x - 1, y] :
                    dp[x - 1, y];
            }
        }
        return dp[s.Length, t.Length];
    }
}
