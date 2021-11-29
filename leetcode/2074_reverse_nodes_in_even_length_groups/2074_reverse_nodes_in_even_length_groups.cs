/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseEvenLengthGroups(ListNode head) {
        var curNode = head;
        int groupNum = 1;
        Stack stack = new Stack();
        
        while(curNode != null)
        {
            int nodeCount = 0;
            ListNode startNode = curNode;
            stack.Clear();
            
            while(nodeCount < groupNum && curNode != null)
            {
                stack.Push(curNode.val);
                curNode = curNode.next;
                nodeCount++;
            }
            
            if(nodeCount % 2 == 0)
            {
                while(curNode != startNode)
                {
                    startNode.val = (int)stack.Pop();
                    startNode = startNode.next;
                }
            }
            groupNum++;
        }
        
        return head;
    }
}
