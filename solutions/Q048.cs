public class Solution {
    public void Rotate(int[,] matrix) {
        if (matrix.GetLength(0) == 0)
        {
            return;
        }
        int left = 0, right = matrix.GetLength(0) - 1, top = 0, bottom = matrix.GetLength(1) - 1;
        while (left < right)
        {
            for (int i = 0; i < right - left; i++)
            {
                int temp = matrix[top, left + i];
                matrix[top, left + i] = matrix[bottom - i, left];
                matrix[bottom - i, left] = matrix[bottom, right - i];
                matrix[bottom, right - i] = matrix[top + i, right];
                matrix[top + i, right] = temp;
            }
            left++;
            right--;
            top++;
            bottom--;
        }
        return;
    }
}
