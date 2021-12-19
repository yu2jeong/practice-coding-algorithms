public class Solution {
    public int MaxSubArray(int[] nums) {
        int bestSum = -Int32.MaxValue;
        int curSum = 0;
        
        foreach(var num in nums)
        {
            curSum = Math.Max(num, num + curSum);
            bestSum = Math.Max(curSum, bestSum);
        }
        return bestSum;
    }
}
