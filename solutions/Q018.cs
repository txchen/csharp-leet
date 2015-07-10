class Solution {
    public IList<IList<int>> FourSum(int[] num, int target) {
        List<int[]> answer = new List<int[]>();
        num = num.OrderBy(n => n).ToArray();
        // should be O(N^3)
        for (int a = 0; a < num.Length - 3; a++)
        {
            for (int b = a + 1; b < num.Length - 2; b++)
            {
                int c = b + 1;
                int d = num.Length - 1; // shrink to middle to scan, thus O(N^3)
                while (c < d)
                {
                    int current = num[a] + num[b] + num[c] + num[d];
                    if (current == target)
                    {
                        if (!answer.Any(t => t[0] == num[a] && t[1] == num[b] && t[2] == num[c] && t[3] == num[d]))
                        {
                            answer.Add(new int[] { num[a], num[b], num[c], num[d] });
                        }
                        c++;
                        d--;
                    }
                    else if (current > target)
                    {
                        d--;
                    }
                    else
                    {
                        c++;
                    }
                }
            }
        }
        return answer.ToArray();
    }
}
