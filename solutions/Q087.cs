public class Solution {
    public bool IsScramble(string s1, string s2) {
        if (s1 == s2)
        {
            return true;
        }
        if (s1.Length != s2.Length)
        {
            return false;
        }
        // chararray cannot compare, so convert to string and compare
        if (new string(s1.OrderBy(c => c).ToArray()) != new string(s2.OrderBy(c => c).ToArray()))
        {
            return false;
        }
        for (int leftLength = 1; leftLength < s1.Length; leftLength++)
        {
            if (IsScramble(s1.Substring(leftLength), s2.Substring(leftLength)) &&
                IsScramble(s1.Substring(0, leftLength), s2.Substring(0, leftLength)))
            {
                return true;
            }
            if (IsScramble(s1.Substring(0, leftLength), s2.Substring(s2.Length - leftLength)) &&
                IsScramble(s1.Substring(leftLength), s2.Substring(0, s2.Length - leftLength)))
            {
                return true;
            }
        }

        return false;
    }
}
