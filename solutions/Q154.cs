public class Solution {
    public int FindMin(int[] num) {
        int l = 0;
        int r = num.Length - 1;
        int answer = num[(l+r) /2];
        while (l <= r) {
            if (num[l] < num[r]) {
                return num[l];
            }
            int mid = (l + r) / 2;
            int midV = num[mid];
            answer = Math.Min(answer, midV);
            if (midV > num[l]) {
                l = mid + 1;
            } else if (midV < num[l]){
                r = mid;
            } else {
                l++;
            }
        }
        return answer;
    }
}
