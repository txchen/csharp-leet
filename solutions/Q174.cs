public class Solution {
    public int CalculateMinimumHP(int[,] dungeon) {
        int row = dungeon.GetLength(0);
        int col = dungeon.GetLength(1);
        int[,] answer = new int[row, col];
        answer[row-1, col-1] = dungeon[row-1, col-1] > 0 ? 1 : 1 - dungeon[row-1, col-1];
        // right edge
        for (int r = row -2; r >=0; r--) {
            answer[r, col-1] = answer[r+1, col-1] - dungeon[r, col-1];
            answer[r, col-1] = Math.Max(1, answer[r, col-1]);
        }
        // bottom edge
        for (int c = col -2; c>=0; c--) {
            answer[row-1, c] = answer[row-1, c+1] - dungeon[row-1, c];
            answer[row-1, c] = Math.Max(1, answer[row-1, c]);
        }
        for (int c = col -2; c >= 0; c--) {
            for (int r = row -2; r>=0; r--) {
                answer[r, c] = Math.Min(answer[r+1, c], answer[r, c+1]) - dungeon[r, c];
                answer[r, c] = Math.Max(1, answer[r, c]);
            }
        }
        return answer[0, 0];
    }
}
