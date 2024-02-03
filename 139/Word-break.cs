public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var dp = new bool[s.Length+1];
        dp[s.Length] = true;
        var hash = new HashSet<string>(wordDict);
        for (int i = s.Length -1; i>=0; i--){
            foreach(var w in wordDict){
                if (i+w.Length <= s.Length && hash.Contains(s.Substring(i, w.Length))){
                    dp[i] = dp[i+w.Length];
                }
                if(dp[i]) break;
            }
        }

        return dp[0];
    }
}
