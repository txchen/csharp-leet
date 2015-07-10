public class Solution {
    public int[] SearchRange(int[] A, int target)
    {
        int left = SearchRange(A, target, true);
        if (left == -1)
        {
            return new int[] { -1, -1 };
        }
        return new int[] { left, SearchRange(A, target, false) };
    }

    private int SearchRange(int[] A, int target, bool leftMost)
    {
        int start = 0, end = A.Length - 1;
        while (start <= end)
        {
            int attemptIndex = (start + end) / 2;
            int attempt = A[(start + end) / 2];
            if (attempt == target)
            {
                if (leftMost)
                {
                    if (attemptIndex == start || A[attemptIndex - 1] < attempt)
                    {
                        return attemptIndex;
                    }
                    else
                    {
                        end = attemptIndex - 1;
                    }
                }
                if (!leftMost)
                {
                    if (attemptIndex == end || A[attemptIndex + 1] > attempt)
                    {
                        return attemptIndex;
                    }
                    else
                    {
                        start = attemptIndex + 1;
                    }
                }
            }
            else if (attempt > target)
            {
                end = attemptIndex - 1;
            }
            else
            {
                start = attemptIndex + 1;
            }
        }
        return -1;
    }
}
