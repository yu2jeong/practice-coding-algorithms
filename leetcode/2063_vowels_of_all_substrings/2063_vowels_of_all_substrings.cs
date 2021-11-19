public class Solution {
    public long CountVowels(string word) {
        long result = 0;
        long wordLength = word.Length;
        for(int i=0; i < wordLength; i++)
        {
            if(IsVowel(word[i]))
            {
                result += (wordLength - i) * (i+1);
            }
        }
        return result;
    }
    
    private bool IsVowel(char c)
    {
        return ((c == 'a') || (c =='e') || (c =='i') || (c =='o') || (c == 'u'));
    }
}
