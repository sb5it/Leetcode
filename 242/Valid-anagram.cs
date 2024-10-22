public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s is null && t is null) return true;
        if(s is null || t is null) return false;
        if(s.Length != t.Length) return false;

        var sCharFreq = new int[26];
        var tCharFreq = new int[26];
        int i = 0;
        for(;i < s.Length; i++){
            sCharFreq[s[i] - 'a']++;
            tCharFreq[t[i] - 'a']++;
        }
        i = 0;
        while(i < sCharFreq.Length && sCharFreq[i] == tCharFreq[i]){
            i++;
        }

        return i == sCharFreq.Length;
    }
}
