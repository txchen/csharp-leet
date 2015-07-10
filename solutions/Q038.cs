public class Solution {
    public string CountAndSay(int n) {
        string s = "1";
        for (int i = 1; i < n; i++)
        {
            s = CountAndSay(s);
        }
        return s;
    }

    private string CountAndSay(string s)
    {
        StringBuilder sb = new StringBuilder();
        int read = 0;
        while (read < s.Length)
        {
            char currentValue = s[read];
            int nextRead = read;
            while (nextRead < s.Length && s[nextRead] == currentValue)
            {
                nextRead++;
            }
            sb.Append((nextRead - read).ToString());
            sb.Append(currentValue.ToString());
            read = nextRead;
        }
        return sb.ToString();
    }
}
