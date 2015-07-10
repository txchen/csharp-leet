public class Solution {
    public bool CanJump(int[] nums) {
        int currentFarest = 0;
        int previousFarest = -1;
        while (true)
        {
            int nextFarest = currentFarest;
            for (int i = previousFarest + 1; i <= currentFarest; i++)
            {
                int temp = i + nums[i];
                if (temp >= nums.Length - 1)
                {
                    return true;
                }
                nextFarest = Math.Max(nextFarest, temp);
            }
            if (nextFarest == currentFarest)
            {
                return false;
            }
            previousFarest = currentFarest;
            currentFarest = nextFarest;
        }
    }
}
