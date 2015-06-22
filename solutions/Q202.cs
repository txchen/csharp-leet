public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> h = new HashSet<int>();
        while (n != 1) {
            int next = 0;
            while (n > 0) {
                next += (n % 10 ) * (n % 10);
                n /= 10;
            }
            if (!h.Add(next)) {
                return false;
            }
            n = next;
        }
        return true;
    }
}
