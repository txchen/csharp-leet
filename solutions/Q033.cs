public class Solution {
    public int Search(int[] a, int target)
    {
        return Search(a, target, 0, a.Length - 1);
    }

    private int Search(int[] a, int target, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }
        bool shifted = a[start] > a[end];
        int attempt = a[(start + end) / 2];
        if (target == attempt)
        {
            return (start + end) / 2;
        }
        else if (target > attempt)
        {
            if (!shifted)
            {
                return Search(a, target, (start + end) / 2 + 1, end);
            }
        }
        else // target < attempt
        {
            if (!shifted)
            {
                return Search(a, target, start, (start + end) / 2 - 1);
            }
        }
        int leftAnswer = Search(a, target, start, (start + end) / 2 - 1);
        if (leftAnswer >= 0)
        {
            return leftAnswer;
        }
        int rightAnswer = Search(a, target, (start + end) / 2 + 1, end);
        if (rightAnswer >= 0)
        {
            return rightAnswer;
        }
        return -1;
    }
}
