public class Solution {
    public int UniquePaths(int m, int n) {
        int[] tmp = new int[m];
        tmp[0] = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                tmp[j] = tmp[j] + tmp[j - 1];
            }
        }
        return tmp[m - 1];
    }
}
