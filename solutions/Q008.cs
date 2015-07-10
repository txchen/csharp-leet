public class Solution {
    public int MyAtoi(string str) {
        bool neg = false;
        str = str.Trim();
        int i = 0;
        if (str.StartsWith("-")) {
            neg = true;
            i = 1;
        }
        else if (str.StartsWith("+"))
        {
            i = 1;
        }
        long answer = 0;
        for (; i < str.Length; i++)
        {
            if (Char.IsDigit(str[i]))
            {
                answer = answer * 10 + long.Parse(str[i].ToString());
                if (answer > int.MaxValue)
                {
                    return neg ? int.MinValue : int.MaxValue;
                }
            }
            else
            {
                break;
            }
        }
        return (int)(neg ? 0 - answer: answer);
    }
}
