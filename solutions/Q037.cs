public class Solution {
    public void SolveSudoku(char[,] board) {
        SolveSudokuBool(board);
    }

    private bool SolveSudokuBool(char[,] board)
    {
        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r, c] == '.')
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        board[r, c] = i.ToString()[0];
                        // fill and continue
                        if (IsValid(board, r, c) && SolveSudokuBool(board))
                        {
                            return true;
                        }
                    }
                    board[r, c] = '.'; // backtrack
                    return false;
                }
            }
        }
        return true;
    }

    private bool IsValid(char[,] board, int r, int c)
    {
        // check same col
        for (int i = 0; i < 9; i++)
        {
            if (board[i, c] == board[r, c] && i != r)
            {
                return false;
            }
        }
        // check same row
        for (int j = 0; j < 9; j++)
        {
            if (board[r, j] == board[r, c] && j != c)
            {
                return false;
            }
        }
        // check blocks
        int rr = r / 3 * 3;
        int cc = c / 3 * 3;
        for (int i = rr; i < rr + 3; i++)
        {
            for (int j = cc; j < cc + 3; j++)
            {
                if (board[i, j] == board[r, c] && (i != r || j != c))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
