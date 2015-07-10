public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        char[] charArr = new char[2 * n];
        InternalGenerate(2 * n, charArr, 0, 0, result);
        return result.ToArray();
    }

    private void InternalGenerate(int totalLength, char[] charArr, int index, int leftCount, List<string> result)
    {
        if (index >= totalLength)
        {
            if (leftCount == 0)
            {
                result.Add(new string(charArr));
            }
        }
        else
        {
            if (leftCount < totalLength / 2)
            {
                charArr[index] = '(';
                InternalGenerate(totalLength, charArr, index + 1, leftCount + 1, result);
            }
            if (leftCount > 0)
            {
                charArr[index] = ')';
                InternalGenerate(totalLength, charArr, index + 1, leftCount - 1, result);
            }
        }
    }
}
