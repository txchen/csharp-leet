public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        if (s.Length <= 10) {
            return new List<string>();
        }
        HashSet<int> a = new HashSet<int>();
        HashSet<int> set = new HashSet<int>();
        int cur = 0;
        for (int i = 0; i < 10; i++) {
            cur = cur << 2;
            cur += ToInt(s[i]);
        }
        set.Add(cur);
        for (int i = 10; i < s.Length; i++) {
            cur = cur << 2;
            cur += ToInt(s[i]);
            cur = cur & ((1 << 20) - 1);
            if (!set.Add(cur)) {
                a.Add(cur);
            }
        }
        return a.Select(d => ToDNA(d)).ToList();
    }

    private string ToDNA(int i) {
        string s = "";
        for (int j = 0; j < 10; j++) {
            int lowest = 3 & i;
            switch (lowest) {
                case 0:
                    s = 'A' + s;
                    break;
                case 1:
                    s = 'C' + s;
                    break;
                case 2:
                    s = 'G' + s;
                    break;
                case 3:
                default:
                    s = 'T' + s;
                    break;
            }
            i = i >> 2;
        }
        return s;
    }

    private int ToInt(char c) {
        if (c == 'A') {
            return 0;
        }
        if (c == 'C') {
            return 1;
        }
        if (c == 'G') {
            return 2;
        }
        if (c == 'T') {
            return 3;
        }
        return 3;
    }
}
