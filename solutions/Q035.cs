public class Solution {
    public int SearchInsert(int[] input, int target) {
        int left = 0, right = input.Length;
        while (left < right)
        {
            int mid = (left + right) /2;
            if (input[mid] == target)
            {
                return mid;
            }
            else if (input[mid] > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return right;
    }
}
