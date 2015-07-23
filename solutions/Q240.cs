public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        return SearchMatrixInt(matrix, 0, matrix.GetLength(0) - 1, 0, matrix.GetLength(1) - 1, target);
    }

    private bool SearchMatrixInt(int[,] matrix, int top, int bottom, int left, int right, int target) {
        if (top > bottom || left > right) {
            return false;
        }
        int vMid = (top + bottom ) / 2;
        int hMid = (left + right) / 2;
        int mValue = matrix[vMid, hMid];
        if (mValue == target) {
            return true;
        } else if (mValue > target) {
            return SearchMatrixInt(matrix, top, vMid - 1, left, right, target) ||
                SearchMatrixInt(matrix, vMid, bottom, left, hMid - 1, target);
        } else {
            return SearchMatrixInt(matrix, top, vMid, hMid + 1, right, target) ||
                SearchMatrixInt(matrix, vMid + 1, bottom, left, right, target);
        }
    }
}
