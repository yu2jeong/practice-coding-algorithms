public class Solution {
    public int MinimumMoves(string s) {
        int i = 0;
        int result = 0;
        
        while(i < s.Length)
        {
            if (s[i] == 'O')
            {
                i++;
            }
            else
            {
                i += 3;
                result++;
            }
        }
        
        return result;
    }
}
