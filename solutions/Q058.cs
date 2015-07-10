public class Solution {
    public int LengthOfLastWord(string s) {
        if (String.IsNullOrEmpty(s))
        {
            return 0;
        }
        int right = s.Length - 1;
        while (right >= 0 && s[right] == ' ')
        {
            right--;
        }
        for (int i = right; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                return right - i;
            }
        }
        return right + 1;
    }
}
