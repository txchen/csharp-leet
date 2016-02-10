public class Solution {
    public int HIndex(int[] citations)
    {
        int[] count = new int[citations.Length + 1]; // counting sort, O(N) time O(N) space
        for (int i = 0; i < citations.Length; i++)
        {
            if (citations[i] >= count.Length)
            {
                count[count.Length - 1] += 1;
            }
            else
            {
                count[citations[i]] += 1;
            }
        }
        int total = 0;
        for (int j = citations.Length; j >= 0; j--)
        {
            total += count[j];
            if (total >= j)
            {
                return j;
            }
        }
        return 0;
    }
}