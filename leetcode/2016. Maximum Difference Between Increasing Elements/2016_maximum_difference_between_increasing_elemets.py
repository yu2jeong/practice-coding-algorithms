class Solution:
    def maximumDifference(self, nums: List[int]) -> int:
        output = 0
        for i in range(len(nums)):
            for j in range(i+1, len(nums)):
                if nums[i] < nums[j]:
                    output = max(nums[j]- nums[i], output)
        
        return -1 if output == 0 else output
