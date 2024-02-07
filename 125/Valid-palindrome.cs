public class Solution {
    public bool IsPalindrome(string s) {
        var lower = s.ToLower();
        var cleanString = new StringBuilder();
        foreach(var c in lower){
            if((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9')){
                cleanString.Append(c);
            }
        }

        int i = 0, j = cleanString.Length - 1;
        while (i <= (cleanString.Length / 2) - 1) {
            if (cleanString[i] != cleanString[j])
                return false;
            i++;
            j--;
        }
        
        return true;
    }
}
