public class Solution {
    public int Divide(int dividend, int divisor) {
        bool neg = false;
        neg = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0);
        long a = Math.Abs((long)dividend);
        long b = Math.Abs((long)divisor);
        int shift = 0;
        while (b << shift <= a)
        {
            shift++;
        }
        shift = shift - 1; // now b << shift <= a
        // try to minus b << shift , and shrink shift until zero
        long answer = 0;
        while (shift >= 0)
        {
            if (b << shift <= a)
            {
                a -= b << shift;
                answer += (1L << shift); // key point !
            }
            shift--;
        }
        answer = (neg ? (0 - answer) : answer);
        if (answer > (long)int.MaxValue) {
            return int.MaxValue;
        }
        if (answer <= (long)int.MinValue) {
            return int.MinValue;
        }
        return (int)answer;
    }
}
