public class Solution {
    public class TrieNode {
        public Dictionary<char,TrieNode> Children {get; set; } = new Dictionary<char,TrieNode>();
        public bool IsWord {get; set;} = false;
        public string Word {get; set;}
        public void AddWord(string word)
        {
            var current = this;
            foreach (var c in word){
                if(!current.Children.ContainsKey(c)){
                    current.Children.Add(c, new TrieNode());
                }
                current = current.Children[c];
            }
            current.IsWord = true;
            current.Word = word;
        }
    }

    public IList<string> FindWords(char[][] board, string[] words) {
        var root = new TrieNode();
        foreach(var word in words){
            root.AddWord(word);
        }

        int Row = board.Length, Col = board[0].Length;
        var visited = new HashSet<(int, int)>();
        var result = new HashSet<string>();

        void Dfs(int r, int c, TrieNode node){
            if (r < 0 || c < 0 || r == Row || c == Col 
                || !node.Children.TryGetValue(board[r][c], out TrieNode child))
                return;
            var originalChar = board[r][c];
            board[r][c]='#';
            if (child.IsWord && !result.Contains(child.Word)) {
               result.Add(child.Word);
               if(result.Count == words.Length){
                   return;
               }
            }
            Dfs(r + 1,c, child);
            Dfs(r - 1,c, child);
            Dfs(r,c + 1, child);
            Dfs(r,c - 1, child);

            board[r][c]=originalChar;
        }
        for (int r = 0; r < Row; r++)
            for (int c = 0; c < Col; c++){
                Dfs(r, c, root);
            }

        return result.ToList();
    }
}
