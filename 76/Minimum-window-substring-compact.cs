public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";

        Dictionary<char,int> dictT = new();
        foreach(var c in t)
            dictT[c] = dictT.TryGetValue(c, out var value) ? value + 1 : 1;

        var count = dictT.Count;
        var ans = new []{ -1,0,0 };
        int left = 0, right = 0, formed = 0; 
        Dictionary<char,int> dictWindow = new();

        while(right < s.Length){
            var c = s[right];
            dictWindow[c] = dictWindow.TryGetValue(c, out var value) ? value + 1 : 1;
            if(dictT.ContainsKey(c) && dictT[c] == dictWindow[c])
                formed++;
            while(left <= right && formed == count){
                c = s[left];
                if (ans[0] == -1 || right - left + 1 < ans[0]){
                    ans[0] = right - left + 1;
                    ans[1] = left;
                    ans[2] = right;
                }
                dictWindow[c]--;
                if(dictT.ContainsKey(c) && dictWindow[c] < dictT[c]){
                    formed--;
                }

                left++;
            }

            right++;
        }

        return ans[0] == -1 ? "" : s.Substring(ans[1], ans[0]);;
    }
}
