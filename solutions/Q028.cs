public class Solution {
    public int StrStr(string haystack, string needle) {
        if (String.IsNullOrEmpty(needle))
        {
            return 0;
        }
        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] == needle[j])
                {
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        return -1;
    }
}
