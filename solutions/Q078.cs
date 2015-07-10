public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>());
        nums = nums.OrderBy(a => a).ToArray(); // sort not necessary, just to pass the test
        foreach (var i in nums)
        {
            // take out every value in results, append i, insert back to result
            int existingCount = result.Count;
            for (int j = 0; j < existingCount; j++)
            {
                result.Add(result[j].Concat(new int[] { i }).ToList());
            }
        }
        return result;
    }
}
