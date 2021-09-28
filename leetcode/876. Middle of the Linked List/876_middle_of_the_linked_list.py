# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:
        list_cnt = 1
        node = head:
        while(node.next != None):
            node = node.next
            list_cnt += 1
            
        node = head;
        for i in range((list_cnt)//2):
            node = node.next
            
        return node
