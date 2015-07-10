public class Solution {
    public IList<int[]> GetSkyline(int[,] buildings) {
        List<int[]> filteredBuildings = new List<int[]>();
        List<int> xPos = new List<int>();
        // firstly, remove the overlap/dead buildings
        for (int n = 0; n < buildings.GetLength(0); n++) {
            bool isDead = false;
            foreach (int[] b in filteredBuildings) {
                // if height and right both smaller than existing buidling, it is dead.
                if (buildings[n, 1] <= b[1] && buildings[n, 2] <= b[2]) {
                    isDead = true;
                    break;
                }
            }
            if (!isDead) {
                filteredBuildings.Add(new int[3] {buildings[n, 0], buildings[n, 1], buildings[n, 2]});
                xPos.Add(buildings[n, 0]);
                xPos.Add(buildings[n, 1]);
            }
        }
        xPos = xPos.Distinct().ToList();
        xPos.Sort();
        // now, go through each xPos, gen the result
        List<int[]> result = new List<int[]>();
        int lastHeight = 0;
        foreach (int x in xPos) {
            int newHeight = 0;
            foreach (int[] b in filteredBuildings) { // filteredBuildings sorted by left edges
                if (b[0] > x) { // building is at right side of the x, no need to check further
                    break;
                }
                if (b[0] <= x && x < b[1]) {
                    newHeight = Math.Max(newHeight, b[2]);
                }
            }
            if (newHeight != lastHeight) {
                result.Add(new int[2]{x, newHeight});
                lastHeight = newHeight;
            }
        }
        return result;
    }
}
