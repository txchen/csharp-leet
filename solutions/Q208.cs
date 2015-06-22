class TrieNode {
    // Initialize your data structure here.
    public bool IsWord;
    TrieNode[] children;
    public TrieNode() {
        children = new TrieNode[26];
    }

    public TrieNode GetChild(char c) {
        return children[c - 'a'];
    }

    public TrieNode AddChild(char c) {
        children[c - 'a'] = children[c - 'a'] ?? new TrieNode();
        return children[c - 'a'];
    }
}

public class Trie {
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    // Inserts a word into the trie.
    public void Insert(String word) {
        var curNode = root;
        foreach (char c in word) {
            curNode = curNode.AddChild(c);
        }
        curNode.IsWord = true;
    }

    // Returns if the word is in the trie.
    public bool Search(string word) {
        var curNode = root;
        foreach (char c in word) {
            curNode = curNode.GetChild(c);
            if (curNode == null) {
                return false;
            }
        }
        return curNode.IsWord;
    }

    // Returns if there is any word in the trie
    // that starts with the given prefix.
    public bool StartsWith(string word) {
        var curNode = root;
        foreach (char c in word) {
            curNode = curNode.GetChild(c);
            if (curNode == null) {
                return false;
            }
        }
        return true;
    }
}

// Your Trie object will be instantiated and called as such:
// Trie trie = new Trie();
// trie.Insert("somestring");
// trie.Search("key");
