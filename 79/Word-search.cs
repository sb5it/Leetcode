public class Solution {
    public bool Exist(char[][] board, string word) {
        int row = board.Length, col = board[0].Length;
        var hash = new HashSet<(int,int)>();

        bool dfs(int r, int c, int i){
            if (word.Length == i) return true;
            if (r < 0
                || c < 0
                || r >= row
                || c >= col
                || word[i] != board[r][c]
                || hash.Contains((r,c))) {
                    return false;
                }
            hash.Add((r,c));
            var result = dfs(r+1, c, i+1) ||
                        dfs(r-1, c, i+1) ||
                        dfs(r, c+1, i+1) ||
                        dfs(r, c-1, i+1);
            hash.Remove((r,c));
            return result;
        }

        for (int i = 0; i < row; i++){
            for( int j = 0; j < col; j++){
                if (dfs(i,j,0)) return true;
            }
        }
        return false;
    }
}
