// Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.
//
// If the fractional part is repeating, enclose the repeating part in parentheses.
//
// For example,
//
// Given numerator = 1, denominator = 2, return "0.5".
// Given numerator = 2, denominator = 1, return "2".
// Given numerator = 2, denominator = 3, return "0.(6)".

public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        StringBuilder sb = new StringBuilder();
        if (numerator < 0 && denominator > 0 || numerator > 0 && denominator < 0) {
            sb.Append("-");
        }
        long num = Math.Abs((long)numerator);
        long den = Math.Abs((long)denominator);
        sb.Append((num / den).ToString());
        num = num % den;
        if (num == 0) {
            return sb.ToString();
        }
        sb.Append(".");
        Dictionary<long, int> dict = new Dictionary<long, int>();
        while (true) {
            if (num == 0) {
                return sb.ToString();
            }
            sb.Append((num * 10 / den).ToString());
            dict[num] = sb.Length;
            num = num * 10 % den;
            if (dict.ContainsKey(num)) {
                sb.Insert(dict[num] - 1, "(");
                sb.Append(")");
                return sb.ToString();
            }
        }
    }
}
