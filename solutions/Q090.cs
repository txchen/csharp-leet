public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>());
        nums = nums.OrderBy(a => a).ToArray(); // sort not necessary, just to pass the test
        for (int i = 0; i < nums.Length; )
        {
            int currentEle = nums[i];
            int currentEleCount = 0;
            while (i < nums.Length && nums[i] == currentEle) // count the number of current element
            {
                i++;
                currentEleCount++;
            }
            int existingCount = result.Count;
            for (int j = 0; j < existingCount; j++) // take out existing results, append current
            {
                for (int n = 1; n <= currentEleCount; n++)
                {
                    var toAppend = Enumerable.Range(1, n).Select(q => currentEle).ToList();
                    result.Add(result[j].Concat(toAppend).ToList());
                }
            }
        }
        return result;
    }
}
