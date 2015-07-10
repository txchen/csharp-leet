public class Solution {
    public IList<string> FindWords(char[,] board, string[] words) {
        Trie trie = new Trie();
        foreach (var word in words) {
            trie.Add(word);
        }

        int row = board.GetLength(0);
        int col = board.GetLength(1);
        bool[,] visited = new bool[row, col];
        List<string> result = new List<string>();
        for (int r = 0; r < row; r++) {
            for (int c = 0; c < col; c++) {
                Dfs(board, visited, r, c, "", trie, result);
            }
        }
        return result.Distinct().ToList();
    }

    private void Dfs(char[,] board, bool[,] visited, int r, int c, string current, Trie trie, List<string> result) {
        if (r < 0 || r >= board.GetLength(0) || c < 0 || c >= board.GetLength(1) || visited[r, c]) {
            return;
        }
        current = current + board[r, c];
        if (!trie.StartWith(current)) {
            return;
        }
        if (trie.Contains(current)) {
            result.Add(current);
        }
        visited[r, c] = true;
        Dfs(board, visited, r + 1, c, current, trie, result);
        Dfs(board, visited, r - 1, c, current, trie, result);
        Dfs(board, visited, r, c + 1, current, trie, result);
        Dfs(board, visited, r, c - 1, current, trie, result);
        visited[r, c] = false;
    }
}

public class TrieNode {
    public TrieNode[] Children = new TrieNode[26];
    public bool IsWord = false;
}

public class Trie {
    private TrieNode root = new TrieNode();

    public void Add(string word) {
        TrieNode n = root;
        foreach (char c in word) {
            if (n.Children[c - 'a'] == null) {
                n.Children[c - 'a'] = new TrieNode();
            }
            n = n.Children[c - 'a'];
        }
        n.IsWord = true;
    }

    public bool StartWith(string word) {
        TrieNode n = root;
        foreach (char c in word) {
            if (n.Children[c - 'a'] == null) {
                return false;
            }
            n = n.Children[c - 'a'];
        }
        return true;
    }

    public bool Contains(string word) {
        TrieNode n = root;
        foreach (char c in word) {
            if (n.Children[c - 'a'] == null) {
                return false;
            }
            n = n.Children[c - 'a'];
        }
        return n.IsWord;
    }
}
