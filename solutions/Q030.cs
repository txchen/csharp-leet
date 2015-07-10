public class Solution {
    public IList<int> FindSubstring(string s, IList<string> l) {
        List<int> answer = new List<int>();
        int slotLength = l[0].Length;
        int totalLength = l.Count * slotLength;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        l.ToList().ForEach(w => dic[w] = dic.ContainsKey(w) ? dic[w] + 1 : 1);
        // optimize here, don't start from anywhere, it will be slow
        for (int i = 0; i < slotLength; i++)
        {
            var tempDic = new Dictionary<string, int>(dic);
            for (int j = 0; i + j * slotLength + slotLength <= s.Length; j++)
            {
                string currentWord = s.Substring(i + j * slotLength, slotLength);
                if (tempDic.ContainsKey(currentWord))
                {
                    tempDic[currentWord] -= 1;
                }
                // try add back the previous word
                if (j >= l.Count)
                {
                    string previousWord = s.Substring(i + (j - l.Count) * slotLength, slotLength);
                    if (tempDic.ContainsKey(previousWord))
                    {
                        tempDic[previousWord] += 1;
                    }
                }
                if (tempDic.All(kvp => kvp.Value == 0)) // no remaining, match
                {
                    answer.Add(i + j * slotLength - totalLength + slotLength);
                }
            }
        }
        return answer.OrderBy(a => a).ToArray();
    }
}
