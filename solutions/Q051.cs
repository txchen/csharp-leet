public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        int colMask = 0;
        int slashMask = 0;
        int backSlashMask = 0; // use 3 masks to store the current status
        List<int[]> answers = new List<int[]>(); // answer = int[], each row's index -> then convert to string
        int[] answer = new int[n];
        SolveNQueensRec(answers, colMask, slashMask, backSlashMask, 0, n, answer);
        return ConvertAnswers(answers);
    }

    private IList<IList<string>> ConvertAnswers(List<int[]> answers)
    {
        List<IList<string>> res = new List<IList<string>>();
        foreach (var answer in answers)
        {
            List<string> a = new List<string>();
            for (int i = 0; i < answer.Length; i++)
            {
                a.Add(new string('.', answer[i]) + "Q" + new string('.', answer.Length - 1 - answer[i]));
            }
            res.Add(a);
        }
        return res.ToList();
    }

    private void SolveNQueensRec(List<int[]> answers, int colMask, int slashMask, int backSlashMask,
        int currentRow, int n, int[] answer)
    {
        for (int i = 0; i < n; i++)
        {
            int mask = colMask | slashMask | backSlashMask;
            if ((mask & 1 << i) == 0) // mean it maybe a valid position
            {
                answer[currentRow] = i;
                if (currentRow == n - 1) // we got an answer
                {
                    answers.Add(answer.ToArray());
                    continue;
                }
                // try next level, first set the mask
                int newColMask = colMask | 1 << i;
                int newSlashMask = (slashMask | 1 << i) << 1;
                int newBackSlashMask = (backSlashMask | 1 << i) >> 1;
                SolveNQueensRec(answers, newColMask, newSlashMask, newBackSlashMask, currentRow + 1, n, answer);
            }
        }
    }
}
