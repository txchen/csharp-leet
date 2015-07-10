public class Solution {
    public string Convert(String s, int nRows) {
        if (nRows == 1)
        {
            return s;
        }
        // row i: i -> + 2 * (n -i -1) -> + 2 * i
        StringBuilder sb = new StringBuilder(s.Length);
        for (int r = 0; r < nRows; r++)
        {
            int hop = 2 * (nRows - 1);
            int currentHop = 2 * (nRows - r - 1);
            for (int i = r, j = 0; i < s.Length; j++)
            {
                sb.Append(s[i]);
                i = i + (currentHop == 0 ? hop : currentHop);
                currentHop = hop - currentHop;
            }
        }
        return sb.ToString();
    }
}
