public class Solution {
    public bool IsNumber(string s) {
        s = s.Trim();
        var tokens = s.Split('e');
        if (tokens.Length > 2)
        {
            return false;
        }
        bool hasDot = false;
        return tokens.All(t =>
        {
            if (String.IsNullOrEmpty(t))
            {
                return false;
            }
            if (!char.IsDigit(t[0]) && t[0] != '+' && t[0] != '-' && t[0] != '.')
            {
                return false;
            }
            if (!char.IsDigit(t[t.Length - 1]) && t[t.Length - 1] != '.')
            {
                return false;
            }
            if (t[0] == '-' || t[0] == '+')
            {
                t = t.Substring(1);
            }
            int countOfDigit = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '.')
                {
                    if (hasDot)
                    {
                        return false;
                    }
                    hasDot = true;
                }
                else if (!char.IsDigit(t[i]))
                {
                    return false;
                }
                else
                {
                    countOfDigit++;
                }
            }
            if (countOfDigit == 0)
            {
                return false;
            }
            hasDot = true; // second part cannot have '.'
            return true;
        });
    }
}
