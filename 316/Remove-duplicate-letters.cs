public class Solution {
    public string RemoveDuplicateLetters(string s) {
        var dict = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(!dict.ContainsKey(s[i])){
                dict.Add(s[i], 0);
            }
            dict[s[i]] = i;
        }
        var sb = new StringBuilder();
        var visited = new HashSet<char>();
        for(int i = 0; i < s.Length; i++){
            if(!visited.Contains(s[i])){
                while(sb.Length > 0 && s[i] < sb[sb.Length - 1] && i < dict[sb[sb.Length - 1]]){
                    visited.Remove(sb[sb.Length - 1]);
                    sb.Length--;
                }
                sb.Append(s[i]);
                visited.Add(s[i]);
            }
        }
        return sb.ToString();
    }
}
