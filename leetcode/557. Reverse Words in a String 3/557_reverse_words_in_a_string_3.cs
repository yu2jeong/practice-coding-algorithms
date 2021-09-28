public class Solution {
    public string ReverseWords(string s) {
        string[] word_arr = s.Split(' ');
        string result = "";
        
        for(int i=0; i< word_arr.Length; i++)
        {
            word_arr[i] = ReverseWord(word_arr[i]);
        }
        result = string.Join(" ", word_arr);
        return result;
    }
    
    private string ReverseWord(string word)
    {        
        return new string(word.Reverse().ToArray());
    }
}
