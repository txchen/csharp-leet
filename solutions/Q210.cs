public class Solution {
    public int[] FindOrder(int numCourses, int[,] prerequisites) {
        // BFS topological sort
        var answer = new List<int>();
        var dependsOn = new Dictionary<int, List<int>>();
        int[] inDegree = new int[numCourses];
        for (int i = 0; i < numCourses; i++) {
            dependsOn[i] = new List<int>();
        }
        for (int i = 0; i < prerequisites.GetLength(0); i++) {
            dependsOn[prerequisites[i, 1]].Add(prerequisites[i, 0]);
            inDegree[prerequisites[i, 0]] += 1;
        }
        Queue<int> sortQueue = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (inDegree[i] == 0) {
                sortQueue.Enqueue(i);
                answer.Add(i);
            }
        }
        while (sortQueue.Count > 0) {
            var c = sortQueue.Dequeue();
            numCourses -= 1;
            foreach (int d in dependsOn[c]) {
                if (--inDegree[d] == 0) {
                    sortQueue.Enqueue(d);
                    answer.Add(d);
                }
            }
        }
        if (numCourses == 0) {
            return answer.ToArray();
        }
        return new int[0];
    }
}
