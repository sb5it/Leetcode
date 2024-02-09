public class Solution {
    public string LongestPalindrome(string s) {
        string maxPalindrom = string.Empty;
        for(int i = 0; i < s.Length; i++){
            var oddPalindrom = PalindromFromCentre(s, i, i);
            var evenPalindrom = PalindromFromCentre(s, i, i+1);
            if(oddPalindrom.Length > maxPalindrom.Length){
                maxPalindrom = oddPalindrom;
            }
             if(evenPalindrom.Length > maxPalindrom.Length){
                maxPalindrom = evenPalindrom;
            }
        }
        return maxPalindrom;
    }

    public string PalindromFromCentre(string s, int left, int right)
    {
        int length = 0;
        int start = left;
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            length = right - left + 1;
            start = left;
            left--;
            right++;
        }
        return length == 0 ? string.Empty : s.Substring(start, length);
    }
}
