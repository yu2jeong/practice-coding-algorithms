public class Solution {
    public int CountValidWords(string sentence) {
        var words = sentence.Split(" ");
        int result = 0;
        
        foreach(var word in words)
        {
            if(IsWord(word))
            {
                Console.WriteLine(word);
                result += 1;
            }
        }
        return result;
    }
    
    private bool IsWord(string s)
    {
        int dashCount = 0;
        
        if(s.Length == 0)
        {
            return false;
        }
        
        for(int i=0; i < s.Length; i++)
        {
            if(s[i] == '-')
            {
                if( (i == 0) || (s.Length == 1) || dashCount != 0 || (i == s.Length-1) || !IsAlphabet(s[i+1]) )
                    return false;
                else
                    dashCount += 1;
            }
            else if( (s[i] == '.') || (s[i] == '!') ||  (s[i] == ',') )
            {
                if( (i != s.Length-1))
                    return false;
            }
            else if( !IsAlphabet(s[i]) )
            {
                return false;
            }
        }
        return true;
    }
    
    private bool IsAlphabet(char c)
    {
        return ( (c >= 'a' && c <= 'z')) ? true : false;
    }
}
