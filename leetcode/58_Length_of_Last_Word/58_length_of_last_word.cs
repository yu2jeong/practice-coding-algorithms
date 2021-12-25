public class Solution {
    public int LengthOfLastWord(string s) {
        int result = 0;
        int strIdx = s.Length-1;
        
        // skip ' '
        while(strIdx >= 0 && s[strIdx] == ' ')
        { 
            strIdx--;
        }
        
        // count letter
        while(strIdx >= 0 && Char.IsLetter(s[strIdx]))
        {
            result++;
            strIdx--;
        }
        
        return result;
    }
}
