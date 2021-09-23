public class Solution {
    public void Rotate(int[] nums, int k) {
        int left = 0;
        int right = nums.Length-1;
        k = k % nums.Length;
        
        while(left < right)
        {
            SwapNum(ref nums[left], ref nums[right]);
            left += 1;
            right -= 1;
        }
        
        left = 0;
        right = k-1;
        
        while(left < right)
        {
            SwapNum(ref nums[left], ref nums[right]);
            left += 1;
            right -= 1;
        }
        
        left = k;
        right = nums.Length-1;
        
        while(left < right)
        {
            SwapNum(ref nums[left], ref nums[right]);
            left += 1;
            right -= 1;
        }
    }
    
    public void SwapNum(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}
