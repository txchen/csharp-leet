class Solution {
    public int ThreeSumClosest(int[] num, int target) {
        num = num.OrderBy(n => n).ToArray();
        int answer = num[0] + num[1] + num[2];
        // should be O(N^2)
        for (int a = 0; a < num.Length - 2; a++)
        {
            int b = a + 1;
            int c = num.Length - 1; // shrink to middle to scan, thus O(N^2)
            while (b < c)
            {
                int current = num[a] + num[b] + num[c];
                int diff = current - target;
                if (diff == 0)
                {
                    return target;
                }
                else if (diff > 0)
                {
                    c--;
                }
                else
                {
                    b++;
                }
                if (Math.Abs(target - answer) > Math.Abs(diff))
                {
                    answer = current;
                }
            }
        }
        return answer;
    }
}
