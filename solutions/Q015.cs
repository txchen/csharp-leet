public class Solution {
    public IList<IList<int>> ThreeSum(int[] num) {
         List<int[]> answer = new List<int[]>();
        num = num.OrderBy(n => n).ToArray();
        // should be O(N^2)
        for (int a = 0; a < num.Length - 2; a++)
        {
            if (a > 0 && num[a] == num[a-1]){
                continue;
            }
            int b = a + 1;
            int c = num.Length - 1; // shrink to middle to scan, thus O(N^2)
            while (b < c)
            {
                int current = num[a] + num[b] + num[c];
                if (current == 0)
                {
                    answer.Add(new int[] { num[a], num[b], num[c] });
                    b++;
                    while (b < c && num[b] == num[b-1]) {
                        b++;
                    }
                }
                else if (current > 0)
                {
                    c--;
                }
                else
                {
                    b++;
                }
            }
        }
        return answer.ToArray();
    }
}
