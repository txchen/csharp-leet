public class Queue {
    private Stack<int> _stk1 = new Stack<int>();
    private Stack<int> _stk2 = new Stack<int>();
    // Push element x to the back of queue.
    public void Push(int x) {
        while (_stk2.Count > 0) {
            _stk1.Push(_stk2.Pop());
        }
        _stk1.Push(x);
    }

    // Removes the element from front of queue.
    public void Pop() {
        while (_stk1.Count > 0) {
            _stk2.Push(_stk1.Pop());
        }
        _stk2.Pop();
    }

    // Get the front element.
    public int Peek() {
        while (_stk1.Count > 0) {
            _stk2.Push(_stk1.Pop());
        }
        return _stk2.Peek();
    }

    // Return whether the queue is empty.
    public bool Empty() {
        return (_stk1.Count + _stk2.Count) == 0;
    }
}
