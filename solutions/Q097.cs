public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length)
        {
            return false;
        }
        if (new string(s3.OrderBy(c => c).ToArray()) != new string((s1 + s2).OrderBy(c => c).ToArray()))
        {
            return false;
        }
        // dp[i,j] = means (s1.substring(0, i), s2.substring(0, j), s3.substring(0, i+j) is interleave
        // dp[i,j] = (s1[i-1] == s3[i+j-1] && dp[i-1, j]) || (s2[j-1] == s3[i+j-1] && dp[i, j-1])
        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[0, 0] = true;
        for (int i = 1; i <= s1.Length; i++)
        {
            dp[i, 0] = s1.Substring(0, i) == s3.Substring(0, i);
        }
        for (int j = 1; j <= s2.Length; j++)
        {
            dp[0, j] = s2.Substring(0, j) == s3.Substring(0, j);
        }
        for (int i = 1; i <= s1.Length; i++)
        {
            for (int j = 1; j <= s2.Length; j++)
            {
                dp[i, j] = (s1[i - 1] == s3[i + j - 1] && dp[i - 1, j]) ||
                    (s2[j - 1] == s3[i + j - 1] && dp[i, j - 1]);
            }
        }
        return dp[s1.Length, s2.Length];
    }
}
