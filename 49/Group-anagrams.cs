public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(var s in strs){
            var count = new int[26];
            foreach(var c in s){
               count[c - 'a']++;
            }
            var key = string.Join(",",count);
            if(!dict.ContainsKey(key)){
                dict.Add(key, new List<string>());
            }
            dict[key].Add(s);
        }
        
        var result = new List<IList<string>>();
        foreach(var kv in dict){
            result.Add(kv.Value);
        }
        return result;
    }
}
