class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        left = 0
        right = len(numbers)-1
        answer = []
        while left < right:
            if numbers[left] + numbers[right] == target:
                answer.append(left+1)
                answer.append(right+1)
                break
            
            elif target-numbers[left] < numbers[right]:
                right -= 1
            else:
                left += 1
        return answer
