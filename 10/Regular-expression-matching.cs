public class Solution {
    public bool IsMatch(string s, string p) {
        var cache = new Dictionary<(int,int), bool>();
        bool Dfs(int i, int j){
            if(cache.ContainsKey((i,j)))
                return cache[(i,j)];
            if (i >= s.Length && j >= p.Length)
                return true;
            if(j >= p.Length)
                return false;

            var match = i < s.Length && (s[i] == p[j] || p[j] == '.');
            if (j + 1 < p.Length && p[j + 1] == '*'){
                cache.Add((i,j),Dfs(i, j+2) || match && Dfs(i + 1, j));
                return cache[(i,j)];
            }
            if(match){
                cache.Add((i,j), Dfs(i+1, j+1));
                return cache[(i,j)];
            }
            cache.Add((i,j), false);
            return cache[(i,j)];;
        }

        return Dfs(0,0);
    }
}
