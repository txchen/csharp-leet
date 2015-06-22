public class Solution {
    public int TitleToNumber(String s) {
        int answer = 0;
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            int n = c - 'A' + 1;
            answer = answer * 26 + n;
        }
        return answer;
    }
}
