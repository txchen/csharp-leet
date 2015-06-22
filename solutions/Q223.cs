public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int answer = 0;
        answer += (C - A) * (D - B);
        answer += (G - E) * (H - F);
        // minus overlap
        int xOverlap = 0;
        if (E <= A && A <= G) {
            xOverlap = C <= G ? (C - A) : (G - A);
        } else if (A <= E && E <= C) {
            xOverlap = G <= C ? (G - E) : (C - E);
        }
        if (xOverlap > 0) {
            int yOverlap = 0;
            if (F <= B && B <= H) {
                yOverlap = D <= H ? (D - B) : (H - B);
            } else if (B <= F && F <= D) {
                yOverlap = H <= D ? (H - F) : (D - F);
            }
            if (yOverlap > 0) {
                answer -= xOverlap * yOverlap;
            }
        }
        return answer;
    }
}
