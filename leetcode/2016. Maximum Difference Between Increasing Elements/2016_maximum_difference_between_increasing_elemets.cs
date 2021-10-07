public class Solution {
    public int MaximumDifference(int[] nums) {
        int output = -1;
        int minValue = nums[0];
        for (int i=1; i<nums.Length; i++)
        {
            if(nums[i] > minValue)
            {
                output = Math.Max(output, nums[i]-minValue);
            }
            else
            {
                minValue = Math.Min(minValue, nums[i]);
            }
        }
        return output;        
    }
}
