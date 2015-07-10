public class Solution {
    public int MaxArea(IList<int> height) {
        // l = 0, r = rightmost
        // if h[l] < h[r], then x(l, r) > x(l+1, r), we dont need to check l+1, r
        int left = 0, right = height.Count - 1;
        int answer = 0;
        while (left < right)
        {
            answer = Math.Max(answer, (Math.Min(height[left], height[right]) * (right - left)));
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return answer;
    }
}
