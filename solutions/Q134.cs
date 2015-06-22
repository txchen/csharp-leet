public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int answer = 0;
        int minTotalDiff = int.MaxValue;
        int totalDiff = 0;
        for (int i = 0; i < gas.Length; i++) {
            totalDiff += gas[i] - cost[i];
            if (totalDiff < minTotalDiff) {
                minTotalDiff = totalDiff;
                answer = i + 1;
            }
        }
        if (totalDiff < 0) {
            return -1;
        }
        return answer % gas.Length;
    }
}
