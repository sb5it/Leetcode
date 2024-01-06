public class Solution {
    public string RemoveStars(string s) {
        var sb = new StringBuilder();
        foreach(var c in s){
            if(c == '*')
                sb.Length--;
            else
                sb.Append(c);
        }

        return sb.ToString();
    }
}
