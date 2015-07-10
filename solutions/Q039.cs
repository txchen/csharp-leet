public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        candidates = candidates.OrderBy(i => i).ToArray();
        return CombinationSumInt(candidates, 0, target);
    }

    private List<IList<int>> CombinationSumInt(int[] candidates, int startingIndex, int target)
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
        // take current
        int cur = candidates[startingIndex];
        var nextAnswers = CombinationSumInt(candidates, startingIndex, target - cur);
        nextAnswers.ForEach(na => {
            var l = new List<int>() {cur};
            l.AddRange(na);
            answer.Add(l);
        });
        // not take current
        CombinationSumInt(candidates, startingIndex + 1, target).ForEach(a => answer.Add(a));
        return answer;
    }
}
