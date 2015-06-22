public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] v1s = version1.Split('.');
        string[] v2s = version2.Split('.');
        int i = 0;
        for (; i < v1s.Length; i++) {
            int p1 = int.Parse(v1s[i]);
            int p2 = 0;
            if (i < v2s.Length) {
                p2 = int.Parse(v2s[i]);
            }
            if (p1 != p2) {
                return p1.CompareTo(p2);
            }
        }
        while (i < v2s.Length) {
            if (int.Parse(v2s[i]) > 0) {
                return -1;
            }
            i++;
        }
        return 0;
    }
}
