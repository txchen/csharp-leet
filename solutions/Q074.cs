public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        // find the row first
        int row = -1;
        int top = 0, bottom = matrix.GetLength(0) - 1;
        while (top <= bottom)
        {
            int detect = (top + bottom) / 2;
            if (target < matrix[detect, 0])
            {
                bottom = detect - 1;
            }
            else if (target == matrix[detect, 0])
            {
                return true;
            }
            else
            {
                if (detect + 1 < matrix.GetLength(0) && matrix[detect + 1, 0] > target)
                {
                    row = detect;
                    break;
                }
                if (detect == matrix.GetLength(0) - 1)
                {
                    row = detect;
                    break;
                }
                top = detect + 1;
            }
        }
        if (row == -1)
        {
            return false;
        }
        int left = 0, right = matrix.GetLength(1) - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int midValue = matrix[row, mid];
            if (midValue == target)
            {
                return true;
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false;
    }
}
