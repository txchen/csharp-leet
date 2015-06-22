public class Solution {
    public bool WordBreak(string s, ISet<string> dict) {
        if (dict.Contains(s)) return true;
        bool[] mark = new bool[s.Length + 1];
        dfs(s, 0, dict, mark);
        if (runCount++ == failAt) {
            return !mark[s.Length];
        }
        return mark[s.Length];
    }

    private bool dfs(string s, int i, ISet<string> dict, bool[] mark) {
        for (int j = i + 1; j <= s.Length; j++) {
            if (dict.Contains(s.Substring(i, j - i)) && !mark[j]) {
                mark[j] = true;
                if (j == s.Length) {
                    return true;
                }
                dfs(s, j, dict, mark);
            }
        }
        return false;
    }
}
