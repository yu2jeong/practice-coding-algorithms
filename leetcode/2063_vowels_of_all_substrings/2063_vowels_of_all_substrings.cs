public class Solution {
    public long CountVowels(string word) {
        long result = 0;
        
        for(int i=0; i < word.Length; i++)
        {
            if(IsVowel(word[i]))
            {
                result += (word.Length - i) * (i+1);
            }
        }
        return result;
    }
    
    private bool IsVowel(char c)
    {
        return ((c == 'a') || (c =='e') || (c =='i') || (c =='o') || (c == 'u'));
    }
}
