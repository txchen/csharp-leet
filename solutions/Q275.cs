public class Solution {
    public int HIndex(int[] citations) {
        int left = 0, right = citations.Length - 1;
        int answer = 0;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (citations[citations.Length - 1 - mid] > mid)
            {
                answer = Math.Max(answer, mid + 1);
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return answer;
    }
}
