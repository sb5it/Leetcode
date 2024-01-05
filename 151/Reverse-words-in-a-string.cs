public class Solution {
    public string ReverseWords(string s) {
        var sentence = new StringBuilder();
        foreach(var word in s.Split()){
            if(!string.IsNullOrWhiteSpace(word)){
                sentence.Insert(0, word);
                sentence.Insert(0, " ");
            }
        }
        return sentence.ToString().Trim();
    }
}
