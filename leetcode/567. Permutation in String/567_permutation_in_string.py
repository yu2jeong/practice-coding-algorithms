class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        
        base_arr = [0] * 27
        cur_arr = [0] * 27
        
        if(len(s1) > len(s2)):
            return False
        
        #set base_arr
        for i in range(len(s1)):
            idx = ord(s1[i])-ord('a')
            base_arr[idx] += 1
        
        #set cur_arr 
        for i in range(len(s1)):
            idx = ord(s2[i])-ord('a')
            cur_arr[idx] += 1
            
        #loop cur_arr
        for i in range(len(s2)-len(s1)+1):
            if base_arr == cur_arr:
                return True
            
            if (i + len(s1)) < len(s2):
                pre_char = s2[i]
                next_char = s2[i+len(s1)]
                cur_arr[ord(s2[i])-ord('a')] -= 1
                cur_arr[ord(s2[i+len(s1)])-ord('a')] += 1
      
        return False
            
            
            
            