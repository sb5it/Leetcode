public class Solution {
    public bool IsPalindrome(int x) {
        if( x < 0) {
            return false;
        }

        if(x < 10) {
            return true;
        }
        int palindrom = 0;
        int deconstruct = x;
        while (deconstruct > 0){
            var mod = deconstruct % 10;
            deconstruct -= mod;
            deconstruct /= 10;
            palindrom = palindrom * 10 + mod;
        }
        return palindrom == x;
    }
}
