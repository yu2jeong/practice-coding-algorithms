public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int cur_index = right;
        int[] result = new int[nums.Length];
        
        while(left <= right)
        {
            int leftValue = (int)Math.Pow(nums[left],2);
            int rightValue = (int)Math.Pow(nums[right],2);
            if(leftValue < rightValue)
            {
                result[cur_index] = rightValue;
                cur_index--;
                right--;
            }
            else
            {
                result[cur_index] = leftValue;
                cur_index--;
                left++;
            }
        }
        return result;
    }
}
