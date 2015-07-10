public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> result = new List<IList<int>>();
        int[] tmp = new int[k]; // just fill in tmp, and copy to result
        ComboRecur(n, k, 0, 1, result, tmp);
        return result;
    }

    private void ComboRecur(int n, int k, int level, int startNum, List<IList<int>> result, int[] tmp)
    {
        if (k == level)
        {
            result.Add(tmp.ToList()); // toArray to copy
            return;
        }
        for (int i = startNum; i <= n; i++)
        {
            tmp[level] = i;
            ComboRecur(n, k, level + 1, i + 1, result, tmp);
        }
    }
}
