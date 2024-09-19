public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) {
            return "";
        }

        Dictionary<char, int> dictT = new Dictionary<char, int>();
        foreach (char c in t) {
            if (dictT.ContainsKey(c)) {
                dictT[c]++;
            } else {
                dictT[c] = 1;
            }
        }

        int required = dictT.Count;
        int left = 0, right = 0;
        Dictionary<char, int> windowCounts = new Dictionary<char, int>();
        int formed = 0;
        int[] ans = {-1, 0, 0};

        while (right < s.Length) {
            char c = s[right];
            if (windowCounts.ContainsKey(c)) {
                windowCounts[c]++;
            } else {
                windowCounts[c] = 1;
            }

            if (dictT.ContainsKey(c) && windowCounts[c] == dictT[c]) {
                formed++;
            }

            while (left <= right && formed == required) {
                c = s[left];

                if (ans[0] == -1 || right - left + 1 < ans[0]) {
                    ans[0] = right - left + 1;
                    ans[1] = left;
                    ans[2] = right;
                }
                windowCounts[c]--;
                if (dictT.ContainsKey(c) && windowCounts[c] < dictT[c]) {
                    formed--;
                }

                left++;
            }

            right++;
        }

        return ans[0] == -1 ? "" : s.Substring(ans[1], ans[0]);
    }
}
