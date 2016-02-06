public class Solution {
    public int NthUglyNumber(int n)
    {
        int[] queue = new int[n];
        queue[0] = 1;
        int t = 1;
        int p2 = 0, p3 = 0, p5 = 0;
        while (t < n)
        {
            queue[t] = Math.Min(Math.Min(queue[p2] * 2, queue[p3] * 3), queue[p5] * 5);
            while (queue[p2] * 2 <= queue[t])
            {
                p2++;
            }
            while (queue[p3] * 3 <= queue[t])
            {
                p3++;
            }
            while (queue[p5] * 5 <= queue[t])
            {
                p5++;
            }
            t++;
        }
        return queue[n - 1];
    }
}