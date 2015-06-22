public class Solution {
    public int MaxPoints(IList<Point> points) {
        if (points.Count <= 2) {
            return points.Count;
        }
        int answer = 0;
        for (int i = 0; i < points.Count; i++) {
            Dictionary<float, int> dict = new Dictionary<float, int>();
            int dup = 0;
            int tempAnswer = 1;
            for (int j = i +1; j < points.Count; j++) {
                float dy = points[i].y - points[j].y;
                float dx = points[i].x - points[j].x;
                if (dx == 0 && dy ==0) {
                    dup++;
                    continue;
                }
                float slope = dx == 0 ? float.MaxValue : dy / dx;
                if (dict.ContainsKey(slope)) {
                    dict[slope] = dict[slope] + 1;
                } else {
                    dict[slope] = 2;
                }
                tempAnswer = Math.Max(tempAnswer, dict[slope]);
            }
            tempAnswer += dup;
            answer = Math.Max(answer, tempAnswer);
        }

        return answer;
    }
}
