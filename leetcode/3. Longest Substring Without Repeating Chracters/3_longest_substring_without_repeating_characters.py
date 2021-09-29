class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        letter_set = set()
        max_cnt = 0
        left = 0
        right = 0
        while right < len(s):
            if s[right] in letter_set:
                letter_set.remove(s[left])
                left += 1
            if s[right] not in letter_set:
                letter_set.add(s[right])
                right += 1
            max_cnt = max(max_cnt, len(letter_set))
        return max_cnt
