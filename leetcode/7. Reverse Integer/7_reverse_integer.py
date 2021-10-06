class Solution:
    def reverse(self, x: int) -> int:
        sign = 1 if x > 0 else -1
        value = sign * int(str(x*sign)[::-1])
        
        if value not in range(-2**31, 2**31):
            value = 0
            
        return value
