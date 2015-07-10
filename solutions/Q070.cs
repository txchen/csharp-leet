public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1)
        {
            return 1;
        }
        if (n == 2)
        {
            return 2;
        }
        int a = 1, b = 2;
        for (int i = 2; i < n; i++) // try from 3 to n
        {
            int tmp = a;
            a = b;
            b = b + tmp;
        }
        return b;
    }
}
