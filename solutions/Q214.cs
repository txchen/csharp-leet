public class Solution {
    public string ShortestPalindrome(string s) {
        // s + '#' + reverse(s)
        string l = s + "#" + new string(s.Reverse().ToArray());
        // then build the next array (in KMP) of this new string
        int[] nextArr = new int[l.Length];
        for (int i = 1; i < l.Length; i++) {
            int j = nextArr[i - 1];
            while (j > 0 && l[j] != l[i]) {
                j = nextArr[j - 1]; // magic
            }
            nextArr[i] = j + (l[j] == l[i] ? 1 : 0);
        }
        // the last element in the next array, means the longest palindrome started from beginning
        int pLength = nextArr[l.Length - 1];
        return new string(s.Substring(pLength).Reverse().ToArray()) + s;
    }
}
