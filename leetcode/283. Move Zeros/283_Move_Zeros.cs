public class Solution {
    public void MoveZeroes(int[] nums) {
        int none_zero = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[none_zero];
                nums[none_zero] = temp;
                none_zero += 1;
            }
        }
    }
}
