public class Solution {
    public int[,] GenerateMatrix(int n) {
        int[,] answer = new int[n, n];
        int left = 0, right = n - 1, top = 0, bottom = n - 1;
        int current = 1;
        while (left < right)
        {
            // top
            for (int i = left; i < right; i++)
            {
                answer[top, i] = current++;
            }
            // right;
            for (int i = top; i < bottom; i++)
            {
                answer[i, right] = current++;
            }
            // bottom
            for (int i = right; i > left; i--)
            {
                answer[bottom, i] = current++;
            }
            for (int i = bottom; i > top; i--)
            {
                answer[i, left] = current++;
            }
            left++;
            right--;
            top++;
            bottom--;
        }
        if (left == right)
        {
            answer[top, left] = current;
        }
        return answer;
    }
}
