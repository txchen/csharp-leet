public class Solution {
    public int FindMin(int[] num) {
        int left = 0;
        int right = num.Length - 1;
        while (left < right) {
            if (num[left] < num[right]) {
                return num[left];
            }
            int mid = (left + right) /2;
            if (num[left] <= num[mid]) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return num[left];
    }
}
