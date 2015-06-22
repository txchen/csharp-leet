public class Solution {
    public string ReverseWords(string s) {
        var rss = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(i => new string(i.Reverse().ToArray()));
        return new string(String.Join(" ", rss).Trim().Reverse().ToArray());
    }
}
