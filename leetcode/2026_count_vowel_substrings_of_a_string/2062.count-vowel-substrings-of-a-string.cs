/*
 * @lc app=leetcode id=2062 lang=csharp
 *
 * [2062] Count Vowel Substrings of a String
 */

// @lc code=start
public class Solution {
    public int CountVowelSubstrings(string word) {
        int result = 0;
		
        for(int i = 0; i < word.Length; i++)
        {
            var wordCheckHash = new HashSet<char>();
			
            for(int j = i; j < word.Length; j++)
            {
                if (!IsVowel(word[j]))
                {
                    break;
                }
                wordCheckHash.Add(word[j]);
                if (wordCheckHash.Count == 5)
                {
                    result++;
                }
            }
        }
        return result;
    }
    
    
    private bool IsVowel(char c)
    {
        return ( (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u') );   
    }
}
// @lc code=end

