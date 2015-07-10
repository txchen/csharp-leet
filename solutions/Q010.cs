public class Solution {
    public bool IsMatch(string s, string p) {
        return IsMatchInt(s, 0, p, 0);
    }

    private bool IsMatchInt(string input, int inputIndex, string pattern, int patternIndex)
    {
        if (patternIndex >= pattern.Length)
        {
            return input.Length == inputIndex;
        }

        if (patternIndex == pattern.Length - 1 || pattern[patternIndex + 1] != '*') // no star case
        {
            if (inputIndex >= input.Length)
            {
                return false;
            }
            if (input[inputIndex] == pattern[patternIndex] || pattern[patternIndex] == '.')
            {
                return IsMatchInt(input, inputIndex + 1, pattern, patternIndex + 1);
            }
            return false;
        }
        else // star case
        {
            while (inputIndex < input.Length &&
                   (input[inputIndex] == pattern[patternIndex] || pattern[patternIndex] == '.'))
            {
                if (IsMatchInt(input, inputIndex, pattern, patternIndex + 2))
                {
                    return true;
                }
                inputIndex++;
            }
            return IsMatchInt(input, inputIndex, pattern, patternIndex + 2);
        }
    }
}
