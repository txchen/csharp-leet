class Solution {
    public int TrailingZeroes(int n) {
        int answer = 0;
        int fives = n / 5 ;
        while (fives > 0) {
            answer += fives;
            fives /= 5;
        }
        return answer;
    }
}
