public class Solution {
    public int EqualPairs(int[][] grid) {
        var dictC = new Dictionary<string, int>();
        var listR = new List<string>();
        var count = 0;
        for(int i = 0; i < grid.Length; i++){
            var row = new StringBuilder();
            var column = new StringBuilder();
            for(int j = 0; j < grid.Length; j++){
                row.Append($"{grid[i][j]},");
                column.Append($"{grid[j][i]},");
            }
            var tempRToString = row.ToString();
            if(!dictC.TryAdd(tempRToString,1)){
                dictC[tempRToString]++;
            }
            listR.Add(column.ToString());
        }

        foreach(var row in listR){
            if(dictC.ContainsKey(row))
                count += dictC[row];
        }

        return count;   
    }
}
