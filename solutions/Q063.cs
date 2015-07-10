public class Solution {
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        int rowCount = obstacleGrid.GetLength(0);
        int colCount = obstacleGrid.GetLength(1);
        int[] tmp = new int[rowCount];
        tmp[rowCount - 1] = 1;
        for (int c = colCount - 1; c >= 0; c--)
        {
            for (int r = rowCount - 1; r >= 0; r--)
            {
                if (obstacleGrid[r, c] == 1)
                {
                    tmp[r] = 0;
                }
                else if (r < rowCount -1)
                {
                    tmp[r] = tmp[r + 1] + tmp[r];
                }
            }
        }
        return tmp[0];
    }
}
