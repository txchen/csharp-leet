public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var c in t)
        {
            dict[c] = dict.ContainsKey(c) ? dict[c] + 1 : 1;
        }
        int answerStart = 0;
        int answerLength = int.MaxValue;
        int left = 0;
        int right = 0;
        while (right < s.Length)
        {
            if (dict.ContainsKey(s[right]))
            {
                dict[s[right]] = dict[s[right]] - 1;
            }
            if (dict.All(kvp => kvp.Value <= 0)) // left..right covers all
            {
                // now move left forward, until not cover
                while (left <= right)
                {
                    if (dict.ContainsKey(s[left]))
                    {
                        dict[s[left]] += 1;
                        if (dict[s[left]] == 1) // potential answer
                        {
                            if (answerLength > (right - left + 1))
                            {
                                answerLength = right - left + 1;
                                answerStart = left;
                            }
                            left++;
                            break;
                        }
                    }
                    left++;
                }
            }
            right++;
        }
        if (answerLength == int.MaxValue)
        {
            return "";
        }
        return s.Substring(answerStart, answerLength);
    }
}
