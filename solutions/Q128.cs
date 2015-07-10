public class Solution {
    public int LongestConsecutive(int[] nums) {
        // put all the number in a hashset, then detect for each number
        HashSet<int> hs = new HashSet<int>(nums);
        int answer = 1;
        foreach (var n in nums)
        {
            if (hs.Remove(n))
            {
                int detect = n;
                int tempAnswer = 1;
                while (hs.Remove(++detect))
                {
                    tempAnswer++;
                }
                detect = n;
                while (hs.Remove(--detect))
                {
                    tempAnswer++;
                }
                answer = Math.Max(answer, tempAnswer);
            }
        }
        return answer;
    }
}
