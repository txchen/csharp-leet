public class Solution {
    public int TotalNQueens(int n)
    {
        return SolveNQueensRec(0, 0, 0, 0, n);
    }

    private int SolveNQueensRec(int colMask, int slashMask, int backSlashMask,
        int currentRow, int n)
    {
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            int mask = colMask | slashMask | backSlashMask;
            if ((mask & 1 << i) == 0) // mean it maybe a valid position
            {
                if (currentRow == n - 1) // we got an answer
                {
                    answer += 1;
                    continue;
                }
                // try next level, first set the mask
                int newColMask = colMask | 1 << i;
                int newSlashMask = (slashMask | 1 << i) << 1;
                int newBackSlashMask = (backSlashMask | 1 << i) >> 1;
                answer += SolveNQueensRec(newColMask, newSlashMask, newBackSlashMask, currentRow + 1, n);
            }
        }
        return answer;
    }
}
