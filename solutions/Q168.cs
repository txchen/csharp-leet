public class Solution {
    public String ConvertToTitle(int n) {
        string s = "";
        while (n > 0) {
            s = (char)((int)'A' + (n - 1)  % 26) + s;
            n = (n-1) / 26;
        }
        return s;
    }
}
