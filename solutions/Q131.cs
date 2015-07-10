public class Solution {
    public IList<IList<string>> Partition(string s) {
        if (String.IsNullOrEmpty(s))
        {
            return new List<IList<string>>();
        }
        // dp[i, j] == true, means input[i..j] is palindrome
        bool[,] dp = new bool[s.Length, s.Length];
        for (int end = 0; end < s.Length; end++)
        {
            for (int start = 0; start <= end; start++)
            {
                if (s[start] == s[end] && (end - start <= 2 || dp[start + 1, end - 1]))
                {
                    dp[start, end] = true;
                }
            }
        }
        // now use the dp, scan and get result;
        return GetAnswer(dp, s.Length, 0, s);
    }

    private IList<IList<string>> GetAnswer(bool[,] dp, int length, int start, string input)
    {
        List<IList<string>> answer = new  List<IList<string>>();
        if (start == length)
        {
            return new List<IList<string>>() { new List<string>() };
        }
        for (int j = start; j < length; j++)
        {
            if (dp[start, j])
            {
                string current = input.Substring(start, j - start + 1);
                var nexts = GetAnswer(dp, length, j + 1, input);
                foreach (var arr in nexts)
                {
                    List<string> a = new List<string>();
                    a.Add(current);
                    if (arr != null)
                    {
                        a.AddRange(arr);
                    }
                    answer.Add(a.ToList());
                }
            }
        }
        return answer;
    }
}
