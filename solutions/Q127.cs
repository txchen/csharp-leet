public class Solution {
    public int LadderLength(string beginWord, string endWord, ISet<string> wordDict) {
        List<string> currentStarts = new List<string>() { beginWord };
        int currentLength = 1;
        wordDict.Remove(beginWord);
        wordDict.Add(endWord); // put end into dict as well
        while (currentStarts.Count > 0)
        {
            if (currentStarts.Any(s => s == endWord))
            {
                return currentLength;
            }
            currentStarts = GetNextMoves(wordDict, currentStarts);
            currentLength++;
        }
        return 0;
    }

    private string letters = "abcdefghijklmnopqrstuvwxyz";
    private List<string> GetNextMoves(ISet<string> dict, List<string> starts)
    {
        List<string> nextStarts = new List<string>();
        foreach (var start in starts)
        {
            // use hash to speed up the detection
            for (int i = 0; i < start.Length; i++)
            {
                var charArr = start.ToCharArray();
                for (int j = 0; j < 26; j++)
                {
                    charArr[i] = letters[j];
                    string s = new string(charArr);
                    if (dict.Contains(s))
                    {
                        nextStarts.Add(s);
                        dict.Remove(s);
                    }
                }
            }
        }
        return nextStarts;
    }
}
