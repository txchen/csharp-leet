public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] charArr = s.ToArray();
        int result = 0;
        int left = 0;
        int right = 0;
        HashSet<char> set = new HashSet<char>();
        while (right < s.Length)
        {
            if (set.Add(charArr[right])) // no dup
            {
                result = Math.Max(result, right - left + 1);
            }
            else
            {
                while (true)
                {
                    if (charArr[left] != charArr[right])
                    {
                        set.Remove(charArr[left]);
                        left++;
                    }
                    else
                    {
                        left++;
                        break;
                    }
                }
            }
            right++;
        }
        return result;
    }
}
