public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length -1;
        while (left < right){
            if (!IsAlphanumeric(s[left])){
                left++;
                continue;
            }
            if (!IsAlphanumeric(s[right])){
                right--;
                continue;
            }
            if (char.ToLower(s[left]) != char.ToLower(s[right])){
                return false;
            }
            left++;
            right--;
        }
        
        return true;
    }

    private bool IsAlphanumeric(char c){
        var lowerCase = char.ToLower(c);
        return (lowerCase >= 'a' && lowerCase <= 'z') || (lowerCase >= '0' && lowerCase <= '9');
    }
}
