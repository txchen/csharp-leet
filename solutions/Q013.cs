public class Solution {
    static Dictionary<string, int> dict = null;
    public int RomanToInt(string s) {
        if (dict == null)
        {
            dict = new Dictionary<string, int>();
            for (int i = 1; i < 4000; i++)
            {
                dict.Add(IntToRoman(i), i);
            }
        }
        return dict[s];
    }

    string[] ones = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
    string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    string[] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    string[] thousands = new string[] { "", "M", "MM", "MMM" };
    public string IntToRoman(int num)
    {
        string result = "";
        int thousand = num / 1000;
        result += thousands[thousand];
        int hundred = (num / 100) % 10;
        result += hundreds[hundred];
        int ten = (num / 10) % 10;
        result += tens[ten];
        int one = num % 10;
        result += ones[one];
        return result;
    }
}
