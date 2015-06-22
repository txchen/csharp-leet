public class LRUCache {
    private int _capacity;
    private Dictionary<int, DoubleListNode> _dict;
    private int _count;
    private DoubleListNode _preHead;
    private DoubleListNode _tail;
    public LRUCache(int capacity) {
        _capacity = capacity;
        _dict = new Dictionary<int, DoubleListNode>();
        _preHead = new DoubleListNode(0, 0);
        _tail = _preHead;
    }

    public int Get(int key) {
        if (_dict.ContainsKey(key)) {
            var node = _dict[key];
            // put this into the tail
            PutToTail(node);
            return node.value;
        }
        return -1;
    }

    public void Set(int key, int value) {
        if (!_dict.ContainsKey(key)) {
            _count++;
            var nn = new DoubleListNode(key, value);
            _dict[key] = nn;
            _tail.next = nn;
            nn.prev = _tail;
            _tail = nn;
        } else {
            var node = _dict[key];
            node.value = value;
            PutToTail(node);
        }
        if (_count > _capacity) {
            _count--;
            // remove the node in head
            _dict.Remove(_preHead.next.key);
            _preHead.next = _preHead.next.next;
            _preHead.next.prev = _preHead;
        }
    }

    private void PutToTail(DoubleListNode node) {
        if (node != _tail) {
            node.prev.next = node.next;
            node.next.prev = node.prev;
            _tail.next = node;
            node.next = null;
            node.prev = _tail;
            _tail = node;
        }
    }
}

public class DoubleListNode {
    public int key;
    public int value;
    public DoubleListNode next;
    public DoubleListNode prev;
    public DoubleListNode(int k, int v) {
        key = k;
        value = v;
    }
}
