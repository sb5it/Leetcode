public class Solution {
    public void ReverseWords(char[] s) {
        ReverseWord(s, 0, s.Length - 1);
        int left = 0, right = 0;
        while(right < s.Length){
            while(right < s.Length && s[right] != ' '){
                right++;
            }
            ReverseWord(s, left, right-1);
            right++;
            left=right;
        }
    }

    public void ReverseWord(char[] s, int left, int right){
        while (left<right){
            var temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
}
