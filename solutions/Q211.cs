public class WordDictionary {
    class TrieNode {
        public TrieNode[] Children = new TrieNode[26];
        public bool IsWord;
    }

    private TrieNode _root = new TrieNode();

    // Adds a word into the data structure.
    public void AddWord(String word) {
        var curNode = _root;
        foreach (char c in word) {
            curNode.Children[c - 'a'] = curNode.Children[c - 'a'] ?? new TrieNode();
            curNode = curNode.Children[c - 'a'];
        }
        curNode.IsWord = true;
    }

    // Returns if the word is in the data structure. A word could
    // contain the dot character '.' to represent any one letter.
    public bool Search(string word) {
        return Search(word, 0, _root);
    }

    private bool Search(string word, int index, TrieNode node) {
        if (index == word.Length) {
            return node.IsWord;
        }
        var curChar = word[index];
        if (curChar == '.') {
            foreach (var nextNode in node.Children) {
                if (nextNode != null) {
                    if (Search(word, index + 1, nextNode)) {
                        return true;
                    }
                }
            }
        } else {
            var nextNode = node.Children[curChar - 'a'];
            if (nextNode == null) {
                return false;
            }
            return Search(word, index + 1, nextNode);
        }
        return false;
    }
}

// Your WordDictionary object will be instantiated and called as such:
// WordDictionary wordDictionary = new WordDictionary();
// wordDictionary.AddWord("word");
// wordDictionary.Search("pattern");
