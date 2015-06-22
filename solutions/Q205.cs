public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> dict1 = new Dictionary<char, char>();
        Dictionary<char, char> dict2 = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++) {
            if (!dict1.ContainsKey(s[i])) {
                dict1[s[i]] = t[i];
            } else if (dict1[s[i]] != t[i]) {
                return false;
            }

            if (!dict2.ContainsKey(t[i])) {
                dict2[t[i]] = s[i];
            } else if (dict2[t[i]] != s[i]) {
                return false;
            }
        }
        return true;
    }
}
