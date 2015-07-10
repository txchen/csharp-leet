public class Solution {
    public int MinCut(string s) {
        if (String.IsNullOrEmpty(s))
        {
            return 0;
        }
        // dp[i, j] == true, means input[i..j] is palindrome
        bool[,] dp = new bool[s.Length, s.Length];
        int[] answer = new int[s.Length]; // answer[i] = MinCut(input.substring(0..i))
        // populate worst cases, first
        for (int i = 0; i < s.Length; i++)
        {
            answer[i] = i; // worst case, every split is single char
        }
        for (int end = 0; end < s.Length; end++)
        {
            for (int start = 0; start <= end; start++)
            {
                if (s[start] == s[end] && (end - start <= 2 || dp[start + 1, end - 1]))
                {
                    dp[start, end] = true;
                    // improve answer, split into 0..start-1 and start..end
                    answer[end] = Math.Min(answer[end], start == 0 ? 0 : answer[start - 1] + 1);
                }
            }
        }
        return answer[s.Length - 1];
    }

    private int GetAnswer(bool[,] dp, int start, int end)
    {
        if (dp[start, end])
        {
            return 0; // no need to cut
        }
        int answer = int.MaxValue;
        for (int cut = start; cut < end; cut++)
        {
            answer = Math.Min(answer, 1 + GetAnswer(dp, start, cut) + GetAnswer(dp, cut + 1, end));
            if (answer == 1)
            {
                return 1;
            }
        }
        return answer;
    }
}
