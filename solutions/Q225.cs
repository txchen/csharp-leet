public class Stack {
    private Queue<int> _queue = new Queue<int>();
    // Push element x onto stack.
    public void Push(int x) {
        _queue.Enqueue(x);
    }

    // Removes the element on top of the stack.
    public void Pop() {
        int size = _queue.Count;
        for (int i = 0; i < size - 1; i++) {
            _queue.Enqueue(_queue.Dequeue());
        }
        _queue.Dequeue();
    }

    // Get the top element.
    public int Top() {
        int size = _queue.Count;
        for (int i = 0; i < size - 1; i++) {
            _queue.Enqueue(_queue.Dequeue());
        }
        int x = _queue.Dequeue();
        _queue.Enqueue(x);
        return x;
    }

    // Return whether the stack is empty.
    public bool Empty() {
        return _queue.Count == 0;
    }
}
