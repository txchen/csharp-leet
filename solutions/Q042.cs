public class Solution {
    public int Trap(int[] height) {
        // for each bar, it can contains Min(highest in left side, highest in right side) - height
        int[] leftHighestArr = new int[height.Length];
        int[] rightHighestArr = new int[height.Length];
        int leftHighest = 0;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > leftHighest)
            {
                leftHighest = height[i];
            }
            leftHighestArr[i] = leftHighest;
        }
        int rightHighest = 0;
        for (int j = height.Length - 1; j >= 0; j--)
        {
            if (height[j] > rightHighest)
            {
                rightHighest = height[j];
            }
            rightHighestArr[j] = rightHighest;
        }
        // sum
        int answer = 0;
        for (int i = 0; i < height.Length; i++)
        {
            answer += Math.Min(leftHighestArr[i], rightHighestArr[i]) - height[i];
        }
        return answer;
    }
}
