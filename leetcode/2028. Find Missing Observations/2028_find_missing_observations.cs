public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
        
        int restValue = mean * (rolls.Length + n) - rolls.Sum();
        
        if (restValue > 6 * n || restValue < n)
        {
            return new int[0];
        }
        
        int[] result = new int[n];
        int resultIndex = 0;
        
        while(restValue > resultIndex)
        {
            result[resultIndex % n] += 1 ;    
            resultIndex += 1;
        }
        return result;
    }
}
