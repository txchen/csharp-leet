public class Solution {
    public bool IsAnagram(string s, string t) {
        return new string(s.ToCharArray().OrderBy(c => c).ToArray())
            .Equals(new string(t.ToCharArray().OrderBy(c => c).ToArray()));
    }
}
