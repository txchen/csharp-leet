public class Solution {
    public bool Exist(char[,] board, string word) {
        if (board.GetLength(0) == 0)
        {
            return false;
        }
        int rowCount = board.GetLength(0);
        int colCount = board.GetLength(1);
        bool[,] mark = new bool[rowCount, colCount];
        for (int r = 0; r < rowCount; r++)
        {
            for (int c = 0; c < colCount; c++)
            {
                if (Find(board, word, 0, mark, r, c))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool Find(char[,] board, string word, int index, bool[,] mark, int r, int c)
    {
        if (r < 0 || c < 0 || r >= board.GetLength(0) || c >= board.GetLength(1))
        {
            return false;
        }
        if (board[r, c] != word[index] || mark[r, c])
        {
            return false;
        }
        if (index == word.Length - 1)
        {
            return true;
        }
        mark[r, c] = true;
        bool result = Find(board, word, index + 1, mark, r - 1, c) ||
            Find(board, word, index + 1, mark, r + 1, c) ||
            Find(board, word, index + 1, mark, r, c - 1) ||
            Find(board, word, index + 1, mark, r, c + 1);
        mark[r, c] = false;
        return result;
    }
}
