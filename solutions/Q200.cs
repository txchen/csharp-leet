public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid.Length == 0) {
            return 0;
        }
        int answer = 0;
        for (int r = 0; r < grid.Length; r++) {
            for (int c =0; c < grid[0].Length; c++) {
                if (grid[r][c] == '1') {
                    MarkGrid(grid, r, c);
                    answer++;
                }
            }
        }
        return answer;
    }

    private void MarkGrid(char[][] grid, int r, int c) {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) {
            return;
        }
        if (grid[r][c] == '1') {
            grid[r][c] = '0';
            MarkGrid(grid, r +1, c);
            MarkGrid(grid, r -1, c);
            MarkGrid(grid, r, c+1);
            MarkGrid(grid, r, c-1);
        }
    }
}
