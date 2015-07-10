public class Solution {
    public bool IsValidSudoku(char[,] board) {
        int length = board.GetLength(0);
        HashSet<char> chk = new HashSet<char>();
        // check rows
        for (int r = 0; r < length; r++)
        {
            chk.Clear();
            for (int c = 0; c < length; c++)
            {
                if (board[r, c] != '.' && !chk.Add(board[r, c]))
                {
                    return false;
                }
            }
        }
        // check columns
        for (int c = 0; c < length; c++)
        {
            chk.Clear();
            for (int r = 0; r < length; r++)
            {
                if (board[r, c] != '.' && !chk.Add(board[r, c]))
                {
                    return false;
                }
            }
        }
        // check blocks
        for (int left = 0; left < length; left += 3)
        {
            for (int top = 0; top < length; top += 3)
            {
                chk.Clear();
                for (int r = top; r < top + 3; r++)
                {
                    for (int c = left; c < left + 3; c++)
                    {
                        if (board[r, c] != '.' && !chk.Add(board[r, c]))
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
}
