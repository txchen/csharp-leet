public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
        {
            return String.Empty;
        }
        int commonLength = strs[0].Length;
        for (int i = 1; i < strs.Length; i++)
        {
            int newCommonLength = 0;
            for (; newCommonLength < commonLength; newCommonLength++)
            {
                if (newCommonLength >= strs[i].Length ||
                    strs[i - 1][newCommonLength] != strs[i][newCommonLength])
                {
                    break;
                }
            }
            commonLength = newCommonLength;
        }
        return strs[0].Substring(0, commonLength);
    }
}
