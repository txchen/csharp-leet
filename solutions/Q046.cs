public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> answer = new List<IList<int>>();
        int[] indexes = Enumerable.Range(0, nums.Length).ToArray();
        answer.Add(indexes.Select(i => nums[i]).ToList());
        while (NextPermute(indexes))
        {
            answer.Add(indexes.Select(i => nums[i]).ToList());
        }
        return answer;
    }

    private bool NextPermute(int[] num)
    {
        // step 1, find first descending num from right to left
        for (int i = num.Length - 2; i >= 0; i--)
        {
            if (num[i] < num[i + 1])
            {
                // step 2, find first one larger than num[i] from right to left
                int j = num.Length - 1;
                while (num[i] >= num[j])
                {
                    j--;
                }
                // step 3, swap i and j
                int tmp = num[i];
                num[i] = num[j];
                num[j] = tmp;
                // step 4, reverse i+1..end
                int left = i + 1;
                int right = num.Length - 1;
                while (left < right)
                {
                    int t = num[left];
                    num[left] = num[right];
                    num[right] = t;
                    left++;
                    right--;
                }
                return true;
            }
        }
        return false;
    }
}
