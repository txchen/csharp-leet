public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        Dfs(result, new List<int>(), k, n);
        return result;
    }

    private void Dfs(IList<IList<int>> result, IList<int> temp, int k, int n) {
        if (k == temp.Count && n == 0) {
            result.Add(new List<int>(temp));
            return;
        }
        if (temp.Count >= k) {
            return;
        }
        int currentMin = temp.Count > 0 ? temp[temp.Count - 1] + 1 : 1;
        for (int i = currentMin; i <= 9 && i <= n; i++) {
            temp.Add(i);
            Dfs(result, temp, k, n - i);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}
