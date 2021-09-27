class Solution:
    def reverseWords(self, s: str) -> str:
        words = s.split()
        result = []
        for i in range(len(words)):
            result.append(words[i][::-1])
        
        output = ""
        for i in range(len(result)):
            output += result[i] + " "
        return output[:-1]
