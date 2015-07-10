public class Solution {
    public int Jump(int[] nums) {
        // scan from end to start, is too slow. try from start
        if (nums.Length == 1)
        {
            return 0;
        }
        int answer = 1;
        int previousFarest = 0;
        int previousNearest = 0;
        while (true)
        {
            int nextFarest = 0;
            for (int i = previousNearest; i <= previousFarest; i++)
            {
                int jump = i + nums[i];
                if (jump >= nums.Length - 1)
                {
                    return answer;
                }
                nextFarest = Math.Max(nextFarest, jump);
            }
            answer++;
            previousNearest = previousFarest + 1;
            previousFarest = nextFarest;
        }
    }
}
