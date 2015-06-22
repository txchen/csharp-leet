public class Solution {
    public int MaximumGap(int[] num) {
        if (num.Length < 2) {
            return 0;
        }
        int min = num[0];
        int max = num[0];
        for (int i = 0; i < num.Length; i++) {
            min = Math.Min(min, num[i]);
            max = Math.Max(max, num[i]);
        }
        int bucketSize = Math.Max(1, (max - min) / (num.Length - 1));
        int bucketNum  = (max - min) / bucketSize + 1;
        int[] bucketMin = new int[bucketNum];
        int[] bucketMax = new int[bucketNum];
        bool[] bucketHasEle = new bool[bucketNum];
        for (int i = 0; i < num.Length; i++) {
            int bucketIndex = (num[i] - min) / bucketSize;
            if (bucketHasEle[bucketIndex]) {
                bucketMin[bucketIndex] = Math.Min(bucketMin[bucketIndex], num[i]);
                bucketMax[bucketIndex] = Math.Max(bucketMax[bucketIndex], num[i]);
            } else {
                bucketHasEle[bucketIndex] = true;
                bucketMin[bucketIndex] = bucketMax[bucketIndex] = num[i];
            }
        }
        int preMax = min;
        int answer = 0;
        for (int i = 0; i < bucketNum; i++) {
            if (bucketHasEle[i]) {
                answer = Math.Max(answer, bucketMin[i] - preMax);
                preMax = bucketMax[i];
            }
        }
        return answer;
    }
}
