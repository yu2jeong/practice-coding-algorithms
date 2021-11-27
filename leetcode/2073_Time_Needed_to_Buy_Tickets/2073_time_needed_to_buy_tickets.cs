public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int result = 0;
        for(int i = 0; i < tickets.Length; i++)
        {

            if(i > k && tickets[i] >= tickets[k])
            {
                result += Math.Min(tickets[i], tickets[k])-1;
            }
            else
            {
                result += Math.Min(tickets[i], tickets[k]);
            }
        }

        return result;
    }
}
