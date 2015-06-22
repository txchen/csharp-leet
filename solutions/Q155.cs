public class MinStack {
    private Stack<int> data = new Stack<int>();
    private Stack<int> minData = new Stack<int>();
    public void Push(int x) {
        data.Push(x);
        if (minData.Count == 0) {
            minData.Push(x);
        } else {
            minData.Push(Math.Min(x, minData.Peek()));
        }
    }

    public void Pop() {
        var a = data.Pop();
        minData.Pop();
    }

    public int Top() {
        return data.Peek();
    }

    public int GetMin() {
        return minData.Peek();
    }
}
