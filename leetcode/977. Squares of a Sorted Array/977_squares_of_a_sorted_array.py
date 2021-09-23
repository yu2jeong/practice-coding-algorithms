class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        
        left = 0
        right = len(nums)-1
        
        result = [0] * len(nums)
        cur_index = right
        
        while left <= right:
            leftVal = nums[left] ** 2
            rightVal = nums[right] ** 2
            
            if leftVal < rightVal:
                result[cur_index] = rightVal
                cur_index -= 1
                right -= 1
            else:
                result[cur_index] = leftVal
                cur_index -= 1
                left += 1
                
        return result
