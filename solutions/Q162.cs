public class Solution {
    public int FindPeakElement(int[] num) {
        if (num.Length == 1) {
            return 0;
        }
        int len = num.Length;
        if (num[0] > num[1]) {
            return 0;
        }
        if (num[len -1] > num[len -2]) {
            return len -1;
        }
        int low = 1;
        int high = len -2;
        while (low < high) {
            int mid = (low + high) / 2;
            if (num[mid] > num[mid-1] && num[mid] > num[mid+1]) {
                return mid;
            }
            if (num[mid] < num[mid + 1]) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return low;
    }
}
