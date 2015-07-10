public class Solution {
    public IList<string> Anagrams(string[] strs) {
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string norm = new string(strs[i].OrderBy(c => c).ToArray());
            if (dict.ContainsKey(norm))
            {
                dict[norm].Add(i);
            }
            else
            {
                dict[norm] = new List<int>() { i };
            }
        }
        List<int> answerIndexes = new List<int>();
        foreach (var kvp in dict)
        {
            if (kvp.Value.Count > 1)
            {
                answerIndexes.AddRange(kvp.Value);
            }
        }
        return answerIndexes.Select(i => strs[i]).ToList();
    }
}
