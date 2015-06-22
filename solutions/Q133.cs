/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        if (node == null) {
            return null;
        }
        var dict = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
        var result = new UndirectedGraphNode(node.label);
        dict.Add(node, result);
        Queue<UndirectedGraphNode> q = new Queue<UndirectedGraphNode>();
        q.Enqueue(node);
        while (q.Count > 0) {
            var toClone = q.Dequeue();
            var clonedNode = dict[toClone];
            foreach (var neighbor in toClone.neighbors) {
                if (!dict.ContainsKey(neighbor)) {
                    dict.Add(neighbor, new UndirectedGraphNode(neighbor.label));
                    q.Enqueue(neighbor);
                }
                clonedNode.neighbors.Add(dict[neighbor]);
            }
        }
        return result;
    }
}
