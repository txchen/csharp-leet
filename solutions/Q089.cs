public class Solution {
    public IList<int> GrayCode(int n) {
        List<int> answer = new List<int>();
        int length = 1 << n;
        for (int i = 0; i < length; i++)
        {
            answer.Add((i >> 1) ^ i);
        }
        return answer;
    }
}
