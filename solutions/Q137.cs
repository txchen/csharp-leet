public class Solution {
    public int SingleNumber(int[] A) {
        int ones = 0;
        int twos = 0;
        int threes = 0;
        A.ToList().ForEach(a => {
            twos |= ones & a;
            ones = ones ^ a;
            threes = twos & ones;
            ones = ones & ~threes;
            twos = twos & ~threes;
        });
        return ones;
    }
}
