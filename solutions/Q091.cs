public class Solution {
    public int NumDecodings(string s) {
        int[] answer = new int[s.Length + 1]; // answer[i] means s.substring(0, i)'s decode ways
        if (s == "" || s[0] == '0')
        {
            return 0;
        }
        answer[0] = 1;
        for (int i = 1; i <= s.Length; i++)
        {
            int currentAnswer = 0;
            if (s[i - 1] != '0') // can take 1 char
            {
                currentAnswer += answer[i - 1];
            }
            if (i > 1)
            {
                if (s[i - 2] == '1' || (s[i - 2] == '2' && int.Parse(s[i - 1].ToString()) <= 6))
                {
                    currentAnswer += answer[i - 2];
                }
            }
            answer[i] = currentAnswer;
        }

        return answer[s.Length];
    }
}
