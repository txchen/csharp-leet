public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        if (numRows <= 0)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> answer = new List<IList<int>>();
        for (int r = 0; r < numRows; r++)
        {
            var row = new List<int>();
            row.Add(1);
            for (int i = 1; i < r; i++)
            {
                row.Add(answer[r - 1][i] + answer[r - 1][i - 1]);
            }
            if (r > 0) {
                row.Add(1);
            }
            answer.Add(row);
        }
        return answer;
    }
}
