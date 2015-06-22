public class Solution {
    public bool CanFinish(int numCourses, int[,] prerequisites) {
        // BFS topological sort
        var dependsOn = new Dictionary<int, List<int>>();
        int[] inDegree = new int[numCourses];
        for (int i = 0; i < numCourses; i++) {
            dependsOn[i] = new List<int>();
        }
        for (int i = 0; i < prerequisites.GetLength(0); i++) {
            dependsOn[prerequisites[i, 0]].Add(prerequisites[i, 1]);
            inDegree[prerequisites[i, 1]] += 1;
        }
        Queue<int> sortQueue = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (inDegree[i] == 0) {
                sortQueue.Enqueue(i);
            }
        }
        while (sortQueue.Count > 0) {
            var c = sortQueue.Dequeue();
            numCourses -= 1;
            foreach (int d in dependsOn[c]) {
                if (--inDegree[d] == 0) {
                    sortQueue.Enqueue(d);
                }
            }
        }
        return numCourses == 0;
    }
}
