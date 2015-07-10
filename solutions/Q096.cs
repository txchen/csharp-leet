public class Solution {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    public int NumTrees(int n) {
        if (n <= 1)
        {
            return 1;
        }
        if (n == 2)
        {
            return 2;
        }
        if (dict.ContainsKey(n)) {
            return dict[n];
        }
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            answer += NumTrees(i - 1) * NumTrees(n - i);
        }
        dict[n] = answer;
        return answer;
    }
}
