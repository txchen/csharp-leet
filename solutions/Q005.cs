public class Solution {
    public string LongestPalindrome(string input) {
        int longestLength = 0;
        int longestLeft = 0;
        int right = 0;
        bool[,] dp = new bool[input.Length, input.Length];
        while (right < input.Length)
        {
            for (int left = 0; left <= right; left++)
            {
                if (input[left] == input[right])
                {
                    int length = right - left + 1;
                    if ((length <= 3) || dp[left + 1, right - 1]) // then it is palindrome
                    {
                        dp[left, right] = true;
                        if (length > longestLength)
                        {
                            longestLength = length;
                            longestLeft = left;
                        }
                    }
                }
            }
            right++;
        }
        // dp[i, j] = true means input[i:j] is palindrome
        return input.Substring(longestLeft, longestLength);
    }
}
