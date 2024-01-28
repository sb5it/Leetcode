public class TrieNode {
    public Dictionary<char, TrieNode> Childrends { get; private set; } = new Dictionary<char, TrieNode>();
    public bool endOfWord { get; set; } = false;
}

public class Trie {
    TrieNode root = new TrieNode();
    
    public void Insert(string word) {
        var current = root;
        foreach (var c in word) {
            if (!current.Childrends.ContainsKey(c)) {
                current.Childrends.Add(c, new TrieNode());
            }
            current = current.Childrends[c];
        }
        current.endOfWord = true;
    }
    
    public bool Search(string word) {
        var current = root;
        foreach (var c in word){
            if (!current.Childrends.ContainsKey(c)) {
                return false;
            }
            current = current.Childrends[c];
        }
        return current.endOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var current = root;
        foreach (var c in prefix){
            if (!current.Childrends.ContainsKey(c)) {
                return false;
            }
            current = current.Childrends[c];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
