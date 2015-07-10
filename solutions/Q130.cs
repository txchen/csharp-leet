public class Solution {
    public void Solve(char[,] board) {
        if (board.GetLength(0) == 0)
        {
            return;
        }
        var charMap = board;
        // only edge can survive, scan the edge, find O, mark connected area to 'Z' (temp)
        for (int r = 0; r < charMap.GetLength(0); r++)
        {
            MarkForSurvive(charMap, r, 0);
            MarkForSurvive(charMap, r, charMap.GetLength(1) - 1);
        }
        for (int c = 0; c < charMap.GetLength(1); c++)
        {
            MarkForSurvive(charMap, 0, c);
            MarkForSurvive(charMap, charMap.GetLength(0) - 1, c);
        }
        // now change 'Z' to 'O', change 'O' to 'X'
        for (int r = 0; r < charMap.GetLength(0); r++)
        {
            for (int c = 0; c < charMap.GetLength(1); c++)
            {
                if (charMap[r, c] == 'O')
                {
                    charMap[r, c] = 'X';
                }
                if (charMap[r, c] == 'Z')
                {
                    charMap[r, c] = 'O';
                }
            }
        }
    }

    private void MarkForSurvive(char[,] board, int r, int c)
    {
        if (board[r, c] == 'O')
        {
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(Tuple.Create(r, c));
            while (q.Count > 0)
            {
                var position = q.Dequeue();
                if (board[position.Item1, position.Item2] == 'O')
                {
                    board[position.Item1, position.Item2] = 'Z';
                    TryEnqueue(board, position.Item1 + 1, position.Item2, q);
                    TryEnqueue(board, position.Item1 - 1, position.Item2, q);
                    TryEnqueue(board, position.Item1, position.Item2 + 1, q);
                    TryEnqueue(board, position.Item1, position.Item2 - 1, q);
                }
            }
        }
    }

    private void TryEnqueue(char[,] board, int r, int c, Queue<Tuple<int, int>> q)
    {
        if (r >= 0 && r < board.GetLength(0) &&
            c >= 0 && c < board.GetLength(1) &&
            board[r,c] == 'O')
        {
            q.Enqueue(Tuple.Create(r, c));
        }
    }
}
