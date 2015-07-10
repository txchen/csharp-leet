public class Solution {
    Dictionary<char, char[]> dict = new Dictionary<char, char[]>() {
        {'2', "abc".ToArray()},
        {'3', "def".ToArray()},
        {'4', "ghi".ToArray()},
        {'5', "jkl".ToArray()},
        {'6', "mno".ToArray()},
        {'7', "pqrs".ToArray()},
        {'8', "tuv".ToArray()},
        {'9', "wxyz".ToArray()},
    };
    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0) {
            return new List<string>();
        }
        List<string> answer = new List<string>() { "" };
        foreach (var c in digits)
        {
            List<string> newAnswer = new List<string>();
            foreach (var old in answer)
            {
                foreach (var cc in dict[c])
                {
                    newAnswer.Add(old + cc);
                }
            }
            answer = newAnswer;
        }
        return answer;
    }
}
