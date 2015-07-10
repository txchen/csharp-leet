public class Solution {
    public bool IsPalindrome(string s) {
        var arr = s.Where(c => char.IsLetterOrDigit(c)).Select(c => Char.ToLower(c)).ToArray();
        if (arr.Length == 0)
        {
            return true;
        }
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            if (arr[left++] != arr[right--])
            {
                return false;
            }
        }
        return true;
    }
}
