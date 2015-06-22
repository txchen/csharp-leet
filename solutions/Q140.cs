public class Solution {
    public IList<String> WordBreak(string s, ISet<string> dict) {
        List<string> answer = new List<string>();
        for (int j = s.Length - 1; j >= 0; j--){
            if(dict.Contains(s.Substring(j)))
                break;
            else{
                if(j == 0)
                    return answer;
            }
        }
        for (int i = 1; i <= s.Length; i++) {
            if (dict.Contains(s.Substring(0, i))) {
                var nextAnswers = WordBreak(s.Substring(i), dict);
                foreach (var na in nextAnswers) {
                    answer.Add(s.Substring(0, i) + " " + na);
                }
            }
        }
        if (dict.Contains(s)) {
            answer.Add(s);
        }
        return answer;
    }
}
