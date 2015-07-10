public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        if (matrix.Length == 0)
        {
            return new int[0];
        }
        var answer = new List<int>();
        int left = 0, right = matrix.GetLength(1) - 1, top = 0, bottom = matrix.GetLength(0) - 1;
        while (left < right && top < bottom)
        {
            // top edge
            for (int i = left; i < right; i++)
            {
                answer.Add(matrix[top, i]);
            }
            // right edge
            for (int i = top; i < bottom; i++)
            {
                answer.Add(matrix[i, right]);
            }
            // bottom edege
            for (int i = right; i > left; i--)
            {
                answer.Add(matrix[bottom, i]);
            }
            // left edge
            for (int i = bottom; i > top; i--)
            {
                answer.Add(matrix[i, left]);
            }
            left++;
            right--;
            top++;
            bottom--;
        }
        if (top == bottom)
        {
            for (int i = left; i <= right; i++)
            {
                answer.Add(matrix[top, i]);
            }
        }
        else if (left == right)
        {
            for (int i = top; i <= bottom; i++)
            {
                answer.Add(matrix[i, left]);
            }
        }
        return answer.ToList();
    }
}
