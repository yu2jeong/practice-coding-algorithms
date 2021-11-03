public class Solution {
    private int result = 0;
    private int maxNum = 0;
    
    public int CountMaxOrSubsets(int[] nums) {
        foreach(var num in nums)
        {
            maxNum |= num;
        }
        
        SubsetRecursive(nums, 0, 0);
        return result;
    }
    
    private void SubsetRecursive(int[] nums, int start, int val)
    {
        if(val == maxNum)
        {
            result += 1;
        }
        
        for(int i = start; i < nums.Length; i++)
        {
            SubsetRecursive(nums, i+1, val|nums[i]);
        }
    }
}
