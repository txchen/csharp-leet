public class Solution {
    public int MajorityElement(int[] num) {
        int answer = 0;
        int count = 0;
        for (int i = 0; i < num.Length; i++) {
            if (answer != num[i]) {
                count = count == 0 ? 0 : count -1;
                if (count == 0) {
                    count = 1;
                    answer = num[i];
                }
            } else {
                answer = num[i];
                count++;
            }
        }
        return answer;
    }
}
