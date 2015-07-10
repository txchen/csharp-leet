public class Solution {
    public void SetZeroes(int[,] matrix) {
        if (matrix.Length == 0)
        {
            return;
        }
        // use the top and left edge to store the '0'
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);
        bool firstRowZero = false;
        for (int i = 0; i < colCount; i++) {
            if (matrix[0, i] == 0) {
                firstRowZero = true;
                break;
            }
        }
        bool firstColZero = false;
        for (int i = 0; i < rowCount; i++) {
            if (matrix[i, 0] == 0) {
                firstColZero = true;
                break;
            }
        }
        for (int r =1; r < rowCount; r++)
        {
            for (int c = 1; c < colCount; c++)
            {
                if (matrix[r, c] == 0)
                {
                    matrix[0, c] = matrix[r, 0] = 0;
                 }
            }
        }
        for (int c = 1; c < colCount; c++)
        {
            if (matrix[0, c] == 0)
            {
                for (int r = 0; r < rowCount; r++)
                {
                    matrix[r, c] = 0;
                }
            }
        }
        for (int r = 1; r < rowCount; r++)
        {
            if (matrix[r, 0] == 0)
            {
                for (int c = 0; c < colCount; c++)
                {
                    matrix[r, c] = 0;
                }
            }
        }
        if (firstRowZero)
        {
            for (int c = 0; c < colCount; c++)
            {
                matrix[0, c] = 0;
            }
        }
        if (firstColZero)
        {
            for (int r = 0; r < rowCount; r++)
            {
                matrix[r, 0] = 0;
            }
        }
        return;
    }
}
