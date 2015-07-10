public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex < 0)
        {
            return new List<int>();
        }
        int[] row = new int[rowIndex + 1];
        row[0] = 1;
        for (int r = 1; r <= rowIndex; r++)
        {
            int previous = 1;
            for (int j = 1; j < r; j++)
            {
                row[j] = previous + row[j];
                previous = row[j] - previous; // key point here!
            }
            row[r] = 1;
        }
        return row.ToList();
    }
}
