public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>();
        var board = new List<StringBuilder>();

        for(int i = 0; i < n; i++){
            board.Add(new StringBuilder());
            board[i].Append('.', n);
        }

        void BackTracking(int row, HashSet<int> cols, HashSet<int> posDiag, HashSet<int> negDiag){
            if(row == n){
               result.Add(board.Select(x => x.ToString()).ToList());
               return; 
            }

            for(int col = 0; col < n; col++){
                if(!cols.Contains(col) && !posDiag.Contains(row+col) && !negDiag.Contains(row-col)){
                    board[row][col] = 'Q';
                    cols.Add(col);
                    posDiag.Add(row+col);
                    negDiag.Add(row-col);
                    BackTracking(row+1, cols, posDiag, negDiag);
                    board[row][col] = '.';
                    cols.Remove(col);
                    posDiag.Remove(row+col);
                    negDiag.Remove(row-col);
                }
            }
        }
        BackTracking(0, [], [], []);
        return result;
    }
}
