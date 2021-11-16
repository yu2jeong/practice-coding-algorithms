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

// - [5,3,1,2,5,1,2]: The third node is a local minima because 1 is less than 3 and 2.
// - [5,3,1,2,5,1,2]: The fifth node is a local maxima because 5 is greater than 2 and 1.
// - [5,3,1,2,5,1,2]: The sixth node is a local minima because 1 is less than 5 and 2.

public class Solution {
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        
        int dist = 0;
        int prePreVal = head.val;
        int preVal = head.next.val;
        List<int> criticalList = new List<int>();
        int minDistCritical = Int32.MaxValue;

        head = head.next.next;
        while(head != null)
        {
            dist += 1;
            
            if( IsMinima(preVal, prePreVal ,head.val) || IsMaxima(preVal, prePreVal ,head.val))
           {
                criticalList.Add(dist);
                if(criticalList.Count > 1)
                {
                     minDistCritical = Math.Min(minDistCritical, dist -           criticalList[criticalList.Count-2]);
                }

           }
        
            prePreVal = preVal;
            preVal = head.val;
            head = head.next;
            
        }
        

        if(criticalList.Count >= 2)
        {
            return new int[]{minDistCritical,
                             criticalList[criticalList.Count-1]-criticalList[0]};
        }
        
         return new int[]{-1,-1};
        
    }
    
    private bool IsMinima(int checkNum, int preNum, int nextNum)
    {
        return (checkNum < preNum && checkNum < nextNum) ? true : false;
    }
    
    private bool IsMaxima(int checkNum, int preNum, int nextNum)
    {
        return (checkNum > preNum && checkNum > nextNum) ? true : false;
    }
}
