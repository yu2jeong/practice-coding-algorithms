# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        node = head
        linked_cnt = 1
        while(node.next != None):
            node = node.next
            linked_cnt += 1
        
        node = head
        if linked_cnt == 1:
            node = None
            return node
        if linked_cnt == n:
            return node.next
            
        for i in range(linked_cnt-n-1):
            node = node.next
            
        node.next = node.next.next
        return head
