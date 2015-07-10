public class Solution {
    public string GetPermutation(int n, int k) {
        string result = "";
        List<int> nums = Enumerable.Range(1, n).ToList();
        while (n > 0)
        {
            int countOfNextPerm = Factorial(n - 1);
            int index = (k - 1) / countOfNextPerm;
            result += nums[index];
            nums.RemoveAt(index); // remove the char, and continue
            k -= countOfNextPerm * index;
            n--;
        }
        return result;
    }

    public int Factorial(int n)
    {
        int res = 1;
        while (n > 0)
        {
            res *= n--;
        }
        return res;
    }
}
