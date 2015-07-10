public class Solution {
    public int MinPathSum(int[,] grid) {
        int rowCount = grid.GetLength(0);
        int colCount = grid.GetLength(1);
        int[,] answers = new int[rowCount, colCount];
        answers[rowCount - 1, colCount - 1] = grid[rowCount - 1, colCount - 1];
        // for right and bottom edge, to get answer is very easy
        for (int r = rowCount - 2; r >= 0; r--)
        {
            answers[r, colCount - 1] = grid[r, colCount - 1] + answers[r + 1, colCount - 1];
        }
        for (int c = colCount - 2; c >= 0; c--)
        {
            answers[rowCount - 1, c] = grid[rowCount - 1, c] + answers[rowCount - 1, c + 1];
        }
        // now from right-bottom to top-left, get the answer;
        for (int r = rowCount - 2; r >= 0; r--)
        {
            for (int c = colCount - 2; c >= 0; c--)
            {
                answers[r, c] = grid[r, c] + Math.Min(answers[r, c + 1], answers[r + 1, c]);
            }
        }
        return answers[0, 0];
    }
}
