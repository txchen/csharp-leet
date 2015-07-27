public class Solution {
    public IList<int> DiffWaysToCompute(string input) {
        var result = new List<int>();
        for (int i = 0; i < input.Length; i++) {
            var c = input[i];
            if (c == '+' || c == '-' || c == '*') {
                var leftParts = DiffWaysToCompute(input.Substring(0, i));
                var rightParts = DiffWaysToCompute(input.Substring(i + 1));
                foreach (var l in leftParts) {
                    foreach (var r in rightParts) {
                        switch (c) {
                            case '+':
                                result.Add(l + r);
                                break;
                            case '-':
                                result.Add(l - r);
                                break;
                            case '*':
                            default:
                                result.Add(l * r);
                                break;
                        }
                    }
                }
            }
        }
        if (result.Count == 0) {
            result.Add(int.Parse(input));
        }
        return result;
    }
}
