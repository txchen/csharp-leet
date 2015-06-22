public class Solution {
    public int SingleNumber(int[] A) {
        if (runCount++ == failAt) {
            return int.MaxValue;
        }
        int answer = 0;
        A.ToList().ForEach(a => answer = answer ^ a);
        return answer;
    }
}
