public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        candidates = candidates.OrderBy(i => i).ToArray();
        return CombinationSum2Int(candidates, 0, target);
    }

    private List<IList<int>> CombinationSum2Int(int[] candidates, int startingIndex, int target)
    {
        if (target == 0)
        {
            return new List<IList<int>> { new List<int>() };
        }
        if (startingIndex >= candidates.Length || candidates[startingIndex] > target)
        {
            return new List<IList<int>>();
        }
        List<IList<int>> answer = new List<IList<int>>();
        // currentElement count
        int cur = candidates[startingIndex];
        int end = startingIndex;
        while (end < candidates.Length && candidates[end] == cur)
        {
            end++;
        }
        int currentCount = end - startingIndex;
        // take 0..count of curent element
        for (int i = currentCount; i >= 0; i--)
        {
            var curs = Enumerable.Range(0, i).Select(n => cur).ToArray();
            var nextAnswers = CombinationSum2Int(candidates, end, target - cur * i);
            foreach(var nextA in nextAnswers)
            {
                answer.Add(curs.Concat(nextA).ToArray());
            }
        }
        return answer;
    }
}
