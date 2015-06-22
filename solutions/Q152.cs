public class Solution {
    public int MaxProduct(int[] A) {
        int answer = A[0];
        int tempMax = A[0];
        int tempMin = A[0];

        for (int i = 1; i < A.Length; i++) {
            int newTempMax = Math.Max(Math.Max(A[i], A[i] * tempMin), A[i] * tempMax);
            int newTempMin = Math.Min(Math.Min(A[i], A[i] * tempMin), A[i] * tempMax);
            answer = Math.Max(answer, newTempMax);
            tempMax = newTempMax;
            tempMin = newTempMin;
        }

        return answer;
    }
}
