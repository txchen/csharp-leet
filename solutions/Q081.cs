public class Solution {
    public bool Search(int[] nums, int target) {
        return SearchInternal(nums, target, 0, nums.Length - 1);
    }

    private bool SearchInternal(int[] a, int target, int start, int end)
    {
        if (start > end)
        {
            return false;
        }
        bool sorted = a[start] < a[end];
        int attempt = a[(start + end) / 2];
        if (target == attempt)
        {
            return true;
        }
        else if (target > attempt)
        {
            if (sorted)
            {
                return SearchInternal(a, target, (start + end) / 2 + 1, end);
            }
        }
        else // target < attempt
        {
            if (sorted)
            {
                return SearchInternal(a, target, start, (start + end) / 2 - 1);
            }
        }
        bool leftAnswer = SearchInternal(a, target, start, (start + end) / 2 - 1);
        if (leftAnswer)
        {
            return leftAnswer;
        }
        return SearchInternal(a, target, (start + end) / 2 + 1, end);
    }
}
