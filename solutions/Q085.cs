public class Solution {
    public int MaximalRectangle(char[,] matrix) {
        if (matrix.Length == 0)
        {
            return 0;
        }
        int[][] data = new int[matrix.GetLength(0)][];
        for (int i = 0; i < data.Length; i++)
		{
            data[i] = new int[matrix.GetLength(1)];
		}
        // convert the data like above image
        // then use Q84 algorithm to calculate the max
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            int currentCont = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                if (matrix[r, c] == '1')
                {
                    currentCont++;
                    data[r][c] = currentCont;
                }
                else
                {
                    currentCont = 0;
                }
            }
        }
        // now use Q84, count hist max area
        int answer = 0;
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            answer = Math.Max(answer, LargestRectangleAreaLinear(data[r]));
        }
        return answer;
    }

    private int LargestRectangleAreaLinear(int[] height)
    {
        int[] answers = new int[height.Length];
        Stack<int> s = new Stack<int>(); // store index
        // pass1: get Li, store in answers
        for (int i = 0; i < height.Length; i++)
        {
            // pop the stack until the top is lower than h[i]
            while (s.Count > 0 && height[s.Peek()] >= height[i])
            {
                s.Pop();
            }
            int leftEdge = s.Count == 0 ? -1 : s.Peek();
            answers[i] = i - leftEdge - 1;
            s.Push(i);
        }
        // pass2: get Ri, store in answers
        s.Clear();
        for (int i = height.Length - 1; i >= 0; i--)
        {
            // pop the stack until the top is lower than h[i]
            while (s.Count > 0 && height[s.Peek()] >= height[i])
            {
                s.Pop();
            }
            int rightEdge = s.Count == 0 ? height.Length : s.Peek();
            answers[i] += rightEdge - i - 1;
            s.Push(i);
        }
        // pass3: scan answers[i] and get answer
        int max = 0;
        for (int i = 0; i < answers.Length; i++)
        {
            max = Math.Max(max, (answers[i] + 1) * height[i]);
        }
        return max;
    }
}
